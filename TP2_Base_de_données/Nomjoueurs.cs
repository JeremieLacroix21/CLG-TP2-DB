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
    public partial class Nomjoueurs : Form
    {
        private int Nbjoueurs;
        public Nomjoueurs()
        {
            InitializeComponent();
            Nbjoueurs = 4;
            
        }
        public void AfficherNom()
        {
            string playerName;
            for (int i = 1;i <= Nbjoueurs;i++)
            {
                playerName = "joueur" + i.ToString();
                Label lab  = new Label();
                lab.Text = playerName;
                lab.Name = lab.Text;
                FLP1.Controls.Add(lab);

                TextBox TBX1 = new TextBox();
                FLP1.Controls.Add(TBX1);
                TBX1.Name = playerName;
            }
        }

        private void Nomjoueurs_Load(object sender, EventArgs e)
        {
            AfficherNom();
        }
    }
}
