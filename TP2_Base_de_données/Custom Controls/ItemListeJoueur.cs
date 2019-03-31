using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objets_BD;
using Global;

namespace TP2_Base_de_données.Custom_Controls
{
    public partial class ItemListeJoueur : UserControl
    {
        private const string FORMAT_POINTS = "({0} / {1})";
        private static readonly Color DEF_BACKCOLOR = SystemColors.ControlLightLight;
        private static readonly Color SELECTED_BACKCOLOR = SystemColors.Highlight;
        private static readonly Color DEF_FORECOLOR = SystemColors.ControlText;
        private static readonly Color SELECTED_FORECOLOR = SystemColors.HighlightText;
        
        private int _Num;
        private bool _Selected = false;

        public Joueur Joueur { get; set; }
        public bool Selected { get => _Selected; set => SetSelected(value); }
        public EventHandler PointsButtonClicked;
        public EventHandler StatsButtonClicked;

        public ItemListeJoueur(Joueur item, int numero)
        {
            InitializeComponent();
            Joueur = item;
            _Num = numero;
            // Chaque fois que le pointage du joueur changera, le UI sera mise à jour de façon automatique
            item.PointageChange += (sender, e) => UpdateUIValues();
        }

        private void ItemListeJoueur_Load(object sender, EventArgs e)
        {
            LAB_Num.Text = "#" + _Num.ToString();
            LAB_Alias.Text = Joueur.AliasJoueur;
            UpdateUIValues();
        }

        private void SetSelected(bool value)
        {
            _Selected = value;
            UpdateSelectedStyle();
        }

        private void UpdateSelectedStyle()
        {
            this.BackColor = _Selected ? SELECTED_BACKCOLOR : DEF_BACKCOLOR;
            this.ForeColor = _Selected ? SELECTED_FORECOLOR : DEF_FORECOLOR;
            BTN_Points.ForeColor = SystemColors.ControlText;
            BTN_Stats.ForeColor = SystemColors.ControlText;
        }

        private void UpdateUIValues()
        {
            LAB_Points.Text = string.Format(FORMAT_POINTS, Joueur.CalculerPointageTotal(), DBGlobal.MAX_POINTS_TOTAL);
        }

        private void BTN_Points_Click(object sender, EventArgs e)
        {
            PointsButtonClicked?.Invoke(sender, e);
        }

        private void BTN_Stats_Click(object sender, EventArgs e)
        {
            StatsButtonClicked?.Invoke(sender, e);
        }
    }
}
