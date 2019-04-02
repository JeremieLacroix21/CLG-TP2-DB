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
        private Joueur _SeraAfficher;

        public Joueur SeraAfficher { get => _SeraAfficher; set => SetJoueur(value); }

        public DLG_Stats()
        {
            InitializeComponent();
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

        private void UpdateInfosJoueur()
        {
            throw new NotImplementedException();
        }

        private void UpdatePointsJoueur(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
