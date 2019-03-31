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

namespace TP2_Base_de_données.Custom_Controls
{
    public partial class ListeJoueur : UserControl
    {
        private int _SelectedIndex = -1;

        public readonly List<ItemListeJoueur> Items = new List<ItemListeJoueur>();
        public Joueur SelectedItem { get; private set; }
        public int SelectedIndex { get => _SelectedIndex; set => SetSelectedIndex(value); }

        public ListeJoueur()
        {
            InitializeComponent();
        }

        public void Add(Joueur item)
        {
            var control = new ItemListeJoueur(item, Items.Count + 1);
            FLP_Content.Controls.Add(control);
            Items.Add(control);
            AutoSize = true;
        }

        public void AddRange(params Joueur[] range)
        {
            foreach(var joueur in range)
            {
                this.Add(joueur);
            }
        }

        /// <summary>
        /// Selects the next item of the list. Selects the first item if the next index is out of bound
        /// </summary>
        public void SelectNextItem()
        {
            if (Items.Count > 0)
            {
                if (SelectedIndex == Items.Count - 1 || SelectedIndex == -1)
                    SelectedIndex = 0;
                else
                    SelectedIndex += 1;
            }
        }

        private void SetSelectedIndex(int value)
        {
            if (value >= 0 && value < Items.Count && value != _SelectedIndex)
            {
                if (_SelectedIndex > -1)
                    Items[_SelectedIndex].Selected = false;
                _SelectedIndex = value;
                Items[_SelectedIndex].Selected = true;

                SelectedItem = Items[_SelectedIndex].Joueur;
            }
        }
    }
}
