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
        }

        private void Start_Load(object sender, EventArgs e)
        {
            // TODO : Migrer ces instructions vers le form Start
            DBGlobal.OuvrirConnexion(this);
            Participants = DBGlobal.Joueurs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jeu lemain = new Jeu();
            lemain.Participants = Participants;
            lemain.ShowDialog();

        }

        private void BTN_AjouterQuestion_Click(object sender, EventArgs e)
        {
            AjouterQuestion ajout = new AjouterQuestion();
            ajout.Show();
        }
    }
}
