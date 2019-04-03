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
    public partial class DLG_Stats : Form
    {
        private List<ProgressBar> _CategoriesPB = new List<ProgressBar>();
        private List<Label> _CategoriesLAB = new List<Label>();

        private Joueur _SeraAfficher;

        public Joueur SeraAfficher { get => _SeraAfficher; set => SetJoueur(value); }

        public DLG_Stats()
        {
            InitializeComponent();

            _CategoriesPB.AddRange(PB_Art, PB_Géo, PB_His, PB_Spo);
            _CategoriesLAB.AddRange(LAB_PointsArt, LAB_PointsGéo, LAB_PointsHis, LAB_PointsSpo);
            _SeraAfficher = null;
        }

        private void SetJoueur(Joueur valeur) {
            if (_SeraAfficher != null)
                _SeraAfficher.PointageChange -= UpdatePointsJoueur;

            if (valeur != null) {
                _SeraAfficher = valeur;
                _SeraAfficher.PointageChange += UpdatePointsJoueur;
                UpdateInfosJoueur();
                UpdatePointsJoueur(null, null);
                this.Show();
            }
            else
                this.Hide();
        }

        private void UpdatePointsJoueur(object sender, EventArgs e)
        {
            UpdateScoreCourant();
            UpdateForces();
            UpdateScoreGlobal();
        }

        private void UpdateInfosJoueur()
        {
            LAB_Alias.Text = SeraAfficher.AliasJoueur;
            LAB_Nom.Text = SeraAfficher.Nom;
            LAB_Prenom.Text = SeraAfficher.Prenom;
        }

        private void UpdateScoreGlobal()
        {
            Dictionary<Categorie, int> scoresDuJoueur = _SeraAfficher.GetScores();
            int maxScore = (scoresDuJoueur.Count > 0) ? scoresDuJoueur.Max().Value : 0;

            foreach (var categorie in DBGlobal.Categories)
            {
                string cat = categorie.Nom.Substring(0, 3);
                Label labPoints = _CategoriesLAB.Find(l => l.Name.Substring(l.Name.Length - 3, 3) == cat);
                ProgressBar pbPoints = _CategoriesPB.Find(p => p.Name.Substring(p.Name.Length - 3, 3) == cat);

                pbPoints.Value = 0;
                labPoints.Text = "0";
                if (scoresDuJoueur.ContainsKey(categorie)) {
                    pbPoints.Maximum = maxScore;
                    pbPoints.Value = scoresDuJoueur[categorie];
                    labPoints.Text = scoresDuJoueur[categorie].ToString();
                }
            }
        }

        private void UpdateScoreCourant()
        {
            List<Categorie> catGagnees = _SeraAfficher.GetCategoriesGagnees_Local();
            List<Categorie> catNonGagnees = DBGlobal.Categories.Where(c => !catGagnees.Contains(c)).ToList();
            DUD_Gagnees.Items.AddRange(catGagnees);
            DUD_AGagner.Items.AddRange(catNonGagnees);
        }

        private void UpdateForces()
        {
            Categorie forte = _SeraAfficher.GetCategorieForce(false);
            Categorie faible = _SeraAfficher.GetCategorieForce(true);
            LAB_CatForte.Text = (forte != null) ? forte.Nom : "Aucune";
            LAB_CatFaible.Text = (faible != null) ? faible.Nom : "Aucune";
        }
    }
}
