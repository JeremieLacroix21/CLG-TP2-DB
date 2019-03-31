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
        private const string FORMAT_POINTS = "{0} / {1}";
        private const string FORMAT_CLASSEMENT = "{0} : {1}({2} / {3})";
        private const string FORMAT_INFOS = "Il ne manque que {0} points à {1} pour gagner en";
        private const string FORMAT_INFOS_WIN = "Bravo à {0}";
        /// <summary>Quand TIMER_Roue atteindra cette durée en ms, la roue s'arrêtera</summary>
        private const double STOPPER_ROUE = 1000;

        private delegate void UpdateControls(Categorie c);
        private delegate void UpdateInfoPanel();
        private EventHandler CategorieEnJeuChange;

        private System.Timers.Timer TIMER_PanneauInfo = new System.Timers.Timer() { Enabled = false, Interval = 7000 };
        private System.Timers.Timer TIMER_Roue = new System.Timers.Timer() { Enabled = false, Interval = 100 };
        private Categorie _CategorieEnJeuValeur;

        private Categorie _CategoriePrecedente = null;
        private Categorie _CategorieEnJeu { get => _CategorieEnJeuValeur; set => SetCategorieEnJeu(value); }
        private Joueur _EnTrainDeJouer = null;

        /// <summary>Les participants seront gardés en ordre de pointage total</summary>
        public List<Joueur> Participants { get; set; }
        /// <summary>Sera null tant qu'aucun joueur n'aura gagné la partie</summary>
        public Joueur Gagnant = null;

        public Jeu()
        {
            InitializeComponent();
            TIMER_PanneauInfo.Elapsed += TIMER_PanneauInfo_Tick;
            TIMER_Roue.Elapsed += TIMER_Roue_Tick;
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            DBGlobal.OuvrirConnexion(this);
            Participants = DBGlobal.Joueurs;
            CategorieEnJeuChange += (s, ev) => this.Invoke(new UpdateInfoPanel(UpdateInfos));
            BW_TimerInfos.RunWorkerAsync();

            UpdateClassement();
            InitJoueurs();
            InitPointage();
            //LancerPartie();
        }

        private void SetCategorieEnJeu(Categorie value)
        {
            _CategorieEnJeuValeur = value;
            if (value != null)
                CategorieEnJeuChange?.Invoke(value, new EventArgs());
        }

        private void InitJoueurs()
        {
            foreach (var joueur in Participants)
            {
                LJ_Participants.Add(joueur);
                joueur.PointageChange += (sender, e) =>
                {
                    this.Invoke(new UpdateInfoPanel(UpdateClassement));
                    this.Invoke(new UpdateInfoPanel(UpdateInfos));
                };
            }
        }

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

        private void LancerPartie()
        {
            while (Gagnant == null)
            {
                _EnTrainDeJouer = ProchainJoueur();
                _EnTrainDeJouer.AliasJoueur += " A";
                //DebloquerRoue();
            }
        }

        private void DebloquerRoue()
        {
            BTN_Tourner.Enabled = true;
        }

        /// <summary>Passe au prochain joueur dans l'ordre de jeu et le retourne</summary>
        private Joueur ProchainJoueur()
        {
            LJ_Participants.SelectNextItem();
            MessageBox.Show("Au tour de " + LJ_Participants.SelectedItem.AliasJoueur + "!\nTournez la roue pour connaitre la catégorie de la prochaine question.");
            return LJ_Participants.SelectedItem;
        }

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
            P_Roue.BackColor = categorie.Couleur;
            LAB_NomCatRoue.BackColor = categorie.Couleur;
            LAB_NomCatRoue.Text = categorie.Nom;
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

        private void TIMER_Roue_Tick(object sender, EventArgs e)
        {
            Categorie categorie;
            Random rand = new Random();
            do
            {
                categorie = DBGlobal.Categories[rand.Next() % DBGlobal.Categories.Count];
            } while (_CategoriePrecedente != null && categorie == _CategoriePrecedente);
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
            this.Invoke(new UpdateInfoPanel(UpdateInfosVisible));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Categorie c = _CategorieEnJeu ?? DBGlobal.Categories[rand.Next() % DBGlobal.Categories.Count];
            _EnTrainDeJouer[c] += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _EnTrainDeJouer = ProchainJoueur();
            DebloquerRoue();
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
    }
}
