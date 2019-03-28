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
    public partial class Main : Form
    {
        private string SelectedCategory = "";
        private Timer letimer = new Timer() {Interval = 100};

        private List<string> listCatégorie = new List<string> { "Histoire", "sport" ,"geographie","Art et culture","choisir"};

        private int Compteur;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            letimer.Tick += Letimer_Tick;
            CBB1.Visible = false;
            foreach(string nom in listCatégorie)
            {
                if (nom != "choisir")
                CBB1.Items.Add(nom);
            }
        }

        private void Letimer_Tick(object sender, EventArgs e)
        {
            
            Random rand = new Random();
           
            label1.Text = listCatégorie[rand.Next() % listCatégorie.Count()];

            if (Compteur == 10)
            {
                Handle_Catégorie(label1.Text);
                Compteur = 0;
                letimer.Stop();
            }
            else
            {

            }
            Compteur++;
        }

        private void FaireRouler()
        {
            letimer.Start();
        }

        private void Touner_Click(object sender, EventArgs e)
        {
            FaireRouler();
        }



        private void Handle_Catégorie(string nomcategorie)
        {
            if (nomcategorie == "choisir")
            {
                CBB1.Visible = true;
            }
        }
    }
}
