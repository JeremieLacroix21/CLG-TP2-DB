using Global;
using Objets_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Base_de_données
{
    public partial class Jeu : Form
    {
        #region Constantes
        private const string FORMAT_POINTS = "{0} / {1}";
        private const string FORMAT_CLASSEMENT = "{0} : {1}({2} / {3})";
        private const string FORMAT_INFOS = "Il ne manque que {0} points à {1} pour gagner en";
        private const string FORMAT_INFOS_WIN = "Bravo à {0}";
        /// <summary>Quand TIMER_Roue atteindra cette durée en ms, la roue s'arrêtera</summary>
        private const double STOPPER_ROUE = 1000;
        #endregion

        #region Delegates pour opérations inter-thread
        // Utiliser avec Control.Invoke() {https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.invoke?view=netframework-4.7.2}
        private delegate void UpdateControls(Categorie c);
        private delegate void UpdateControls_();
        #endregion

        #region Timers
        // Les timers devront être lancés dans des BackgroundWorker afin d'éviter
        // qu'ils s'exécutent sur le UIThread. Faire autrement fera geler aléatoirement l'application.
        // La méthode Controle.Invoke() permettra de mettre à jour les éléments UI depuis les threads des timers.

        /// <summary>Alterne entre le panneau d'infos et le panneau des classements</summary>
        private System.Timers.Timer TIMER_PanneauInfo { get; set; }
        /// <summary>Gère la "rotation" de la roue</summary>
        private System.Timers.Timer TIMER_Roue { get; set; }
        #endregion

        [Obsolete("Utiliser _CategorieEnJeu à la place afin de déclencher les mécanismes dans SetCategorieEnJeu()")]
        private Categorie _CategorieEnJeuValeur;
        private void SetCategorieEnJeu(Categorie value) {
            _CategorieEnJeuValeur = value;
            _CategorieEnJeuChange?.Invoke(value, new EventArgs());
        }

        /// <summary>La catégorie ayant été obtenue au dernier tour de roue. null si la roue n'a jamais tourné.</summary>
        private Categorie _CategoriePrecedente { get; set; }
        /// <summary>Catégorie obtenue par la roue</summary>
        private Categorie _CategorieEnJeu { get => _CategorieEnJeuValeur; set => SetCategorieEnJeu(value); }
        /// <summary>Invoqué dans SetCategorieEnJeu().</summary>
        private EventHandler _CategorieEnJeuChange { get; set; }
        /// <summary>Le joueur en train de faire des actions</summary>
        private Joueur _EnTrainDeJouer { get; set; }

        /// <summary>Les participants seront gardés en ordre de pointage total</summary>
        public List<Joueur> Participants { get; set; }
        /// <summary>Sera null tant qu'aucun joueur n'aura gagné la partie</summary>
        public Joueur Gagnant { get; private set; }

        public Jeu()
        {
            InitializeComponent();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
          

            // Initialiser tout
            InitTimers();
            InitEventHandlers();
            InitJoueurs();
            InitPointage();
            // Lancer le timer utilisé pour alterner entre le panneau d'infos et le panneau des classements
            BW_TimerInfos.RunWorkerAsync();
            // Update initial du panneau des classements ("Aucuns points pour l'instant")
            UpdateClassement();
            // Débuter la partie
            LancerPartie();
        }

        #region Méthodes Init
        private void InitTimers()
        {
            // Initialiser les timers
            TIMER_PanneauInfo = new System.Timers.Timer() { Enabled = false, Interval = 7000 };
            TIMER_Roue = new System.Timers.Timer() { Enabled = false, Interval = 100 };
            // Attribuer les événements Tick au timers
            TIMER_PanneauInfo.Elapsed += TIMER_PanneauInfo_Tick;
            TIMER_Roue.Elapsed += TIMER_Roue_Tick;
        }

        private void InitJoueurs()
        {
            // Ajouter les joueurs à l'interface
            LJ_Participants.AddRange(Participants.ToArray());
        }

        // TODO : Migrer cette méthode vers le form Start
        private void InitPointage()
        {
            foreach (var categorie in DBGlobal.Categories)
            {
                foreach (var joueur in Participants)
                {
                    joueur.AjouterPointage(categorie, 0);
                }
            }
        }

        private void InitEventHandlers()
        {
            // Chaque fois qu'une nouvelle instruction sera écrite dans RTBX_Instructions, la zone de texte clignotera
            RTBX_Instructions.TextChanged += (sender, e) => {
                CustomUtils.Blink(RTBX_Instructions, SystemColors.MenuHighlight, SystemColors.ControlLightLight, 100, 4);
            };

            // Chaque fois que la catégorie va changer, le panneau d'infos sera mise à jour
            _CategorieEnJeuChange += (sender, e) => {
                if (_CategorieEnJeu == null) {
                    this.Invoke(new UpdateControls_(UpdateInfosVisible));
                    this.Invoke(new UpdateControls(UpdateRoue), _CategorieEnJeu);
                } else {
                    this.Invoke(new UpdateControls_(UpdateInfos));
                    this.Invoke(new UpdateControls_(ChargerQuestion));
                }
            };

            // Chaque fois que le pointage d'un participant va changer, le UI sera mise à jour
            foreach (var joueur in Participants) {
                joueur.PointageChange += (sender, e) => {
                    this.Invoke(new UpdateControls_(UpdateClassement));
                    this.Invoke(new UpdateControls_(UpdateInfos));
                };
            }

            Q_Questionnaire.RespondClicked += GererReponse;
        }
        #endregion

        #region Méthodes de jeu
        /// <summary>
        /// Méthode de jeu initiale qui lance la "game loop"
        /// </summary>
        private void LancerPartie()
        {
            //MessageBox.Show(string.Format("Le jeu est très simple, tournez la roue pour obtenir une catégorie, répondez à la question présentée," +
            //    "recommencez jusqu'à avoir {0} points dans chaque catégorie.\nLa partie commence maintenant!", Categorie.GAGNER_NBPOINTS), "Jeu Quiz");
            Question.ResetQuestionsRepondues();
            Categorie.ResetCategoriesGagnee();

            ProchainJoueur();
        }

        /// <summary>Passe au prochain joueur dans l'ordre de jeu et l'assigne à _EnTrainDeJouer. Débloque ensuite la roue.</summary>
        private void ProchainJoueur()
        {
            LJ_Participants.SelectNextItem();
            _EnTrainDeJouer = LJ_Participants.SelectedItem;
            DebloquerRoue();
        }

        private void DebloquerRoue()
        {
            _CategorieEnJeu = null;
            RTBX_Instructions.Text = "Au tour de " + LJ_Participants.SelectedItem.AliasJoueur + "!\n\nTournez la roue pour connaitre la catégorie de la prochaine question.";
            BTN_Tourner.Enabled = true;
        }

        /// <summary>
        /// Charge une question au hasard depuis la base de donnée et la met dans le questionnaire
        /// </summary>
        private void ChargerQuestion()
        {
            Q_Questionnaire.ARepondre = Question.GetQuestionHasard(_CategorieEnJeu);
        }

        private void GererReponse(object sender, EventArgs e)
        {
            if (Q_Questionnaire.Choisie.EstBonne)
            {
                Q_Questionnaire.ARepondre.Repondre();

                _EnTrainDeJouer[_CategorieEnJeu] += Question.POINTS_REPONSE;
                if (_EnTrainDeJouer[_CategorieEnJeu] == Categorie.GAGNER_NBPOINTS)
                    _EnTrainDeJouer.IncrScore(_CategorieEnJeu);

                MessageBox.Show("Bonne réponse!");
                DebloquerRoue();
            }
            else
            {
                MessageBox.Show("Mauvaise réponse!");
                ProchainJoueur();
            }
            Q_Questionnaire.ARepondre = null;
        }
        #endregion

        #region Méthodes Update
        private void UpdateClassement()
        {
            if (Joueur.CalculerPointageTotal(Participants) > 0)
            {
                Participants.Sort();
                LAB_PremierRang.Text = string.Format(FORMAT_CLASSEMENT, "1er", Participants[0].AliasJoueur, Participants[0].CalculerPointageTotal(), DBGlobal.MAX_POINTS_TOTAL);
                LAB_DeuxiemeRang.Text = string.Format(FORMAT_CLASSEMENT, "2e", Participants[1].AliasJoueur, Participants[1].CalculerPointageTotal(), DBGlobal.MAX_POINTS_TOTAL);
                LAB_TroisiemeRang.Text = string.Format(FORMAT_CLASSEMENT, "3e", Participants[2].AliasJoueur, Participants[2].CalculerPointageTotal(), DBGlobal.MAX_POINTS_TOTAL);
            }
            else
            {
                LAB_PremierRang.Text = "";
                LAB_DeuxiemeRang.Text = "Aucuns points pour l'instant";
                LAB_TroisiemeRang.Text = "";
            }
        }

        private void UpdateRoue(Categorie categorie)
        {
            bool aucuneCategorie = categorie == null;

            P_Roue.BackColor = aucuneCategorie ? SystemColors.Control : categorie.Couleur;
            LAB_NomCatRoue.BackColor = aucuneCategorie ? SystemColors.Control : categorie.Couleur;
            LAB_NomCatRoue.Text = aucuneCategorie ? "????" : categorie.Nom;
        }

        private void UpdateInfosVisible()
        {
            if (_CategorieEnJeu == null)
            {
                P_PointsRestants.Visible = false;
                P_Rangs.Visible = true;
            }
            else
            {
                P_PointsRestants.Visible = !P_PointsRestants.Visible;
                P_Rangs.Visible = !P_Rangs.Visible;
            }
        }

        private void UpdateInfos()
        {
            if (_CategorieEnJeu != null)
            {
                if (_EnTrainDeJouer[_CategorieEnJeu] == Categorie.GAGNER_NBPOINTS)
                    LAB_Info.Text = string.Format(FORMAT_INFOS_WIN, _EnTrainDeJouer.AliasJoueur);
                else
                    LAB_Info.Text = string.Format(FORMAT_INFOS, Categorie.GAGNER_NBPOINTS - _EnTrainDeJouer[_CategorieEnJeu], _EnTrainDeJouer.AliasJoueur);
                LAB_NomCatInfos.Text = _CategorieEnJeu.Nom;
                LAB_PointsInfos.Text = string.Format(FORMAT_POINTS, _EnTrainDeJouer[_CategorieEnJeu], Categorie.GAGNER_NBPOINTS);
                PB_PointsInfos.Value = _EnTrainDeJouer[_CategorieEnJeu];
            }
        }
        #endregion

        #region Control Events

        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var joueur in Participants)
            {
                joueur.ClearPointageChange();
            }
        }

        private void BTN_Tourner_Click(object sender, EventArgs e)
        {
            BTN_Tourner.Enabled = false;
            BW_TimerRoue.RunWorkerAsync();
        }

        private void BW_TimerRoue_DoWork(object sender, DoWorkEventArgs e)
        {
            TIMER_Roue.Start();
        }

        private void BW_TimerInfos_DoWork(object sender, DoWorkEventArgs e)
        {
            TIMER_PanneauInfo.Start();
        }

        private void TIMER_Roue_Tick(object sender, EventArgs e)
        {
            Categorie categorie;
            Random rand = new Random();
            List<Categorie> categoriesGagnees = _EnTrainDeJouer.GetCategoriesGagnees_Local();
            do
            {
                categorie = DBGlobal.Categories[rand.Next() % DBGlobal.Categories.Count];
                // La catégorie sélectionner ne pourra par être la même que la précédente et ne pourra pas être une catégorie où le joueur courant à déjà gagné
            } while ((_CategoriePrecedente != null && categorie == _CategoriePrecedente) || categoriesGagnees.Contains(categorie));
            _CategoriePrecedente = categorie;

            this.Invoke(new UpdateControls(UpdateRoue), categorie);

            if (TIMER_Roue.Interval >= STOPPER_ROUE)
            {
                _CategorieEnJeu = categorie;
                _CategoriePrecedente = categorie;

                TIMER_Roue.Interval = 100;
                TIMER_Roue.Stop();
            }
            else
            {
                TIMER_Roue.Interval += TIMER_Roue.Interval / 2;
            }
        }

        private void TIMER_PanneauInfo_Tick(object sender, EventArgs e)
        {
            this.Invoke(new UpdateControls_(UpdateInfosVisible));
        }

        #endregion
    }
}
