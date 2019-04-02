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
    public partial class DLG_Points : Form
    {
        private const string FORMAT_POINTS = "{0} / {1}";

        private List<ProgressBar> _CategoriesPB = new List<ProgressBar>();
        private List<Label> _CategoriesLAB = new List<Label>();

        private Joueur _SeraAfficher;
        private void SetJoueur(Joueur valeur) {
            if (_SeraAfficher != null)
                _SeraAfficher.PointageChange -= UpdatePointsJoueur;

            if (valeur != null)
            {
                _SeraAfficher = valeur;
                _SeraAfficher.PointageChange += UpdatePointsJoueur;
                UpdateInfosJoueur();
                this.Show();
            }
            else
                this.Hide();
        }

        public Joueur SeraAfficher { get => _SeraAfficher; set => SetJoueur(value); }

        public DLG_Points()
        {
            InitializeComponent();
            _SeraAfficher = null;
        }

        private void UpdateInfosJoueur()
        {
            LAB_Alias.Text = SeraAfficher.AliasJoueur;
            LAB_Nom.Text = SeraAfficher.Nom;
            LAB_Prenom.Text = SeraAfficher.Prenom;
        }

        private void UpdatePointsJoueur(object dummySender, EventArgs dummyE)
        {
            foreach (var categorie in DBGlobal.Categories)
            {
                string cat = categorie.Nom.Substring(0, 3);
                Label labPoints = _CategoriesLAB.Find(l => l.Name.Substring(l.Name.Length - 4, 3) == cat);
                ProgressBar pbPoints = _CategoriesPB.Find(p => p.Name.Substring(p.Name.Length - 4, 3) == categorie.Nom.Substring(0, 3));

                labPoints.Text = string.Format(FORMAT_POINTS, SeraAfficher[categorie], Categorie.GAGNER_NBPOINTS);
                pbPoints.Value = SeraAfficher[categorie];
            }
        }

        private void DLG_Points_Load(object sender, EventArgs e)
        {
            _CategoriesPB.AddRange(PB_Art, PB_Geo, PB_His, PB_Spo);
            _CategoriesLAB.AddRange(LAB_PointsArt, LAB_PointsGeo, LAB_PointsHis, LAB_PointsSpo);
        }

        private void DLG_Points_FormClosing(object sender, FormClosingEventArgs e)
        {
            SeraAfficher = null;
        }
    }
}
