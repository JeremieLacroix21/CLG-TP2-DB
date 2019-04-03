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
        private ValidationProvider _Validation { get; set; }
        public List<Joueur> Listeprincipal { get; private set; }

        public JoueurManager()
        {
            InitializeComponent();
            Listeprincipal = new List<Joueur>();
        }

        private void JoueurManager_Load(object sender, EventArgs e)
        {
            Init_UI();
            BTN_Ajouter.Enabled = false;
            BTN_supprimer.Enabled = false;
            _Validation = new ValidationProvider(this);
            _Validation.AddControlToValidate(TBX_Alias, Validate_TBX_Alias);
            _Validation.AddControlToValidate(TBX_Prenom, Validate_TBX_Prénom);
            _Validation.AddControlToValidate(TBX_Nom, Validate_TBX_Nom);
        }

        private void Init_UI()
        {
            CLB_joueurs.Items.Clear();
            foreach (Joueur unjoueur in DBGlobal.Joueurs)
            {
                CLB_joueurs.Items.Add(unjoueur.AliasJoueur + " : " + unjoueur.Prenom + " " + unjoueur.Nom);
            }
        }

        private void Ajouter_Joueur()
        {
            Joueur lejoueur1 = new Joueur();
            lejoueur1.Nom = TBX_Nom.Text;
            lejoueur1.Prenom = TBX_Prenom.Text;
            lejoueur1.AliasJoueur = TBX_Alias.Text;

            DBGlobal.Joueurs.Add(lejoueur1);
            Init_UI();

            lejoueur1.Ajouter();
        }

        private void Supprimer_Joueur()
        {
            Joueur lejoueur = DBGlobal.Joueurs.Find(j => j.AliasJoueur == CLB_joueurs.SelectedItem.ToString().Split(' ')[0]);

            if (MessageBox.Show(lejoueur.AliasJoueur + " va être supprimer de façon permanente, êtes-vous certain ?",
                "Confirmer Suppression Joueur", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBGlobal.Joueurs.Remove(lejoueur);
                Init_UI();

                lejoueur.Supprimer();
            }
        }

        #region Validation

        private bool Validate_TBX_Alias(ref string message)
        {
            bool existeDeja = DBGlobal.Joueurs.Find(j => j.AliasJoueur == TBX_Alias.Text) != null;
            message = existeDeja ? "Veuillez choisir un autre alias, " + TBX_Alias.Text + " est déjà en utilisation" : "Alias manquant";

            return !string.IsNullOrWhiteSpace(TBX_Alias.Text) && !existeDeja;
        }

        private bool Validate_TBX_Prénom(ref string message)
        {
            message = "Prénom manquant";
            return !string.IsNullOrWhiteSpace(TBX_Prenom.Text);
        }

        private bool Validate_TBX_Nom(ref string message)
        {
            message = "Nom de famille manquant";
            return !string.IsNullOrWhiteSpace(TBX_Nom.Text);
        }

        #endregion

        private void TBX_TextChanged(object sender, EventArgs e)
        {
           BTN_Ajouter.Enabled =  _Validation.FormValid();
        }

        private void BTN_Accepter_Click(object sender, EventArgs e)
        {
            if (CLB_joueurs.CheckedItems.Count >= Joueur.NB_JOUEURS_MIN)
            {
                foreach (var itemChecked in CLB_joueurs.CheckedItems)
                {
                    Listeprincipal.Add(DBGlobal.Joueurs.Find(j => j.AliasJoueur == itemChecked.ToString().Split(' ')[0]));
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Il doit y avoir " + Joueur.NB_JOUEURS_MIN + " joueurs au minimum par partie",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            

            Ajouter_Joueur();
            TBX_Alias.Clear();
            TBX_Nom.Clear();
            TBX_Prenom.Clear();
        }

        private void BTN_supprimer_Click(object sender, EventArgs e)
        {
            Supprimer_Joueur();
        }


        private void CLB_joueurs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && CLB_joueurs.CheckedItems.Count == Joueur.NB_JOUEURS_MAX)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("Il ne peut y avoir que " + Joueur.NB_JOUEURS_MAX + " joueurs au maximum par partie",  
                    "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            BTN_supprimer.Enabled = (CLB_joueurs.SelectedItems.Count == 1);
        }

        private void CLB_joueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_supprimer.Enabled = (CLB_joueurs.SelectedItems.Count == 1);
        }
    }
}
