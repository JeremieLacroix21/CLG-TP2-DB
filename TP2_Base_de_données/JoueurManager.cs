using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;
using Objets_BD;
using Global;

namespace TP2_Base_de_données
{
    public partial class JoueurManager : Form
    {

        private ValidationProvider validation;
        public List<Joueur> Listeprincipal;


        public JoueurManager(List<Joueur> part)
        {
            InitializeComponent();
            Listeprincipal = part;
        }

        private void JoueurManager_Load(object sender, EventArgs e)
        {
            Init_UI();
            BTN_Ajouter.Enabled = false;
            BTN_supprimer.Enabled = false;
            validation = new ValidationProvider(this);
            validation.AddControlToValidate(TBX_Nom, Validate_TBX_nom);
            validation.AddControlToValidate(TBX_Prénom, Validate_TBX_Prénom);
            validation.AddControlToValidate(TBX_Lastname, Validate_TBX_Lastname);
        }

        private void Init_UI()
        {
            CLB_joueurs.Items.Clear();
            foreach (Joueur unjoueur in DBGlobal.Joueurs)
            {
                CLB_joueurs.Items.Add(unjoueur.Nom.ToString());
            }
        }

        #region Validation

        private bool Validate_TBX_nom(ref string message)
        {
            message = "Alias manquant";
            return !string.IsNullOrWhiteSpace(TBX_Nom.Text);
        }

        private bool Validate_TBX_Prénom(ref string message)
        {
            message = "¨prénom manquant";
            return !string.IsNullOrWhiteSpace(TBX_Prénom.Text);
        }

        private bool Validate_TBX_Lastname(ref string message)
        {
            message = "Nom de famille manquant";
            return !string.IsNullOrWhiteSpace(TBX_Lastname.Text);
        }

        #endregion
        private void TBX_Prénom_TextChanged(object sender, EventArgs e)
        {
           BTN_Ajouter.Enabled =  validation.FormValid();
        }

        private void TBX_Lastname_TextChanged(object sender, EventArgs e)
        {
            BTN_Ajouter.Enabled = validation.FormValid();
        }

        private void TBX_Nom_TextChanged(object sender, EventArgs e)
        {
            BTN_Ajouter.Enabled = validation.FormValid();
        }





        private void BTN_Accepter_Click(object sender, EventArgs e)
        {
            List<Joueur> Temporaire = new List<Joueur>();
            foreach (object itemChecked in CLB_joueurs.CheckedItems)
            {
                for (int i = 0; i < Listeprincipal.Count; i++)
                {
                    if (itemChecked.ToString() == Listeprincipal[i].AliasJoueur)
                    {
                        Temporaire.Add(Listeprincipal[i]);
                    }
                }
            }
            Listeprincipal = Temporaire;
            this.Close();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            
                Ajouter_Joueur();
        }

        private void BTN_supprimer_Click(object sender, EventArgs e)
        {
            Supprimer_Joueur();
        }

        private void Ajouter_Joueur()
        {
            Joueur lejoueur1 = new Joueur();
            lejoueur1.Nom = TBX_Lastname.Text;
            lejoueur1.Prenom = TBX_Prénom.Text;
            lejoueur1.AliasJoueur = TBX_Nom.Text;
            lejoueur1.Ajouter();
            DBGlobal.Joueurs.Add(lejoueur1);

        }
        private void Supprimer_Joueur()
        {
            Joueur lejoueur = new Joueur();
            lejoueur.AliasJoueur = CLB_joueurs.SelectedItem.ToString();
            lejoueur.Supprimer();
            Init_UI();
        }

       

        private void CLB_joueurs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (CLB_joueurs.SelectedItems.Count == 1)
            {
                BTN_supprimer.Enabled = true;
            }
            else
            {
                BTN_supprimer.Enabled = false;
            }
        }

        private void CLB_joueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CLB_joueurs.SelectedItems.Count == 1)
            {
                BTN_supprimer.Enabled = true;
            }
            else
            {
                BTN_supprimer.Enabled = false;
            }
        }
    }
}
