using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Global;
using Objets_BD;

namespace Custom_Controls
{
    public partial class ChoisirCategorie : UserControl
    {
        /// <summary>La catégorie choisie par l'utilisateur</summary>
        public Categorie Choisie { get; private set; }
        public EventHandler CategorieEstChoisie { get; set; }
        public new bool Visible { get => base.Visible; set => SetVisible(value); }

        private void SetVisible(bool value)
        {
            base.Visible = value;
            if (value == true)
                Choisie = null;
        }

        public ChoisirCategorie()
        {
            InitializeComponent();
        }

        private void ChoisirCategorie_Load(object sender, EventArgs e)
        {
            if (DBGlobal.Categories != null)
            {
                foreach (var categorie in DBGlobal.Categories)
                {
                    var btn = new Button() { Size = new Size(120, 52), BackColor = categorie.Couleur, Text = categorie.Nom, Font = new Font(this.Font, FontStyle.Bold) };
                    FLP_Content.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Choisie = DBGlobal.Categories.Find(c => c.Nom == (sender as Button).Text);
            Visible = false;
            CategorieEstChoisie?.Invoke(sender, e);
        }
    }
}
