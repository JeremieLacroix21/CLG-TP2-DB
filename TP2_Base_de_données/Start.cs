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
    public partial class Start : Form
    {
        private List<Joueur> Participants;

        public Start()
        {
            InitializeComponent();
            Participants = new List<Joueur>();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            DBGlobal.OuvrirConnexion(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jeu lemain = new Jeu();
            lemain.Participants = this.Participants;
            this.Visible = false;
            lemain.ShowDialog();
            this.Visible = true;
            BTN_jouer.Enabled = false;
        }

        private void BTN_AjouterQuestion_Click(object sender, EventArgs e)
        {
            AjouterQuestion ajout = new AjouterQuestion();
            ajout.Show();
        }

        private void BTN_Configurerjoueur_Click(object sender, EventArgs e)
        {
            JoueurManager manager = new JoueurManager();
            if (manager.ShowDialog() == DialogResult.OK)
            {
                Participants = manager.Listeprincipal;
                BTN_jouer.Enabled = Participants.Count >= Joueur.NB_JOUEURS_MIN;
            }
        }
    }
}
