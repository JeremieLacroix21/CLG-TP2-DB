using Objets_BD;
using Global;
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

namespace TP2_Base_de_données
{
    public partial class AjouterQuestion : Form
    {
        private ValidationProvider validation;

        public AjouterQuestion()
        {
            InitializeComponent();
        }

        private void AjouterQuestion_Load(object sender, EventArgs e)
        {
            
            validation = new ValidationProvider(this);
            validation.AddControlToValidate(RTBX_Question, Validate_question);
            validation.AddControlToValidate(RTBX_A_Reponse, Validate_A_Reponse);
            validation.AddControlToValidate(RTBX_B_Reponse, Validate_B_Reponse);
            validation.AddControlToValidate(RTBX_C_Reponse, Validate_C_Reponse);
            validation.AddControlToValidate(RTBX_D_Reponse, Validate_D_Reponse);
            validation.AddControlToValidate(label2, validate_radiobutton);
            Init_UI();
        }

        private void Init_UI()
        {
                BTN_Ajouter.Enabled = false;
                BTN_Ajouterautre.Enabled = false;
            
            foreach (Categorie lacat in DBGlobal.Categories)
            {
                CBB_catégo.Items.Add(lacat.Nom);
            }
            CBB_catégo.SelectedIndex = 0;
            RBTN_A_Reponse.Checked = true;
        }
        

        private void AjouterlaQuestion()
        {
            Question newq = new Question();
            newq.Categorie = DBGlobal.Categories[CBB_catégo.SelectedIndex];
            newq.Enonce = RTBX_Question.Text;
            Reponse[] Tab = new Reponse[4];
            Tab[0] = new Reponse { Description = RTBX_A_Reponse.Text, EstBonne = RBTN_A_Reponse.Checked, NumReponse = "A", Question = newq };
            Tab[1] = new Reponse { Description = RTBX_B_Reponse.Text, EstBonne = RBTN_B_Reponse.Checked, NumReponse = "B", Question = newq };
            Tab[2] = new Reponse { Description = RTBX_C_Reponse.Text, EstBonne = RBTN_C_Reponse.Checked, NumReponse = "C", Question = newq };
            Tab[3] = new Reponse { Description = RTBX_D_Reponse.Text, EstBonne = RBTN_D_Reponse.Checked, NumReponse = "D", Question = newq };
            newq.Reponses = Tab;
            newq.Ajouter();
        }


        #region validation

        private bool VerifierRadiobutton()
        {
            bool One_is_selected = false;
            if (RBTN_A_Reponse.Checked || RBTN_B_Reponse.Checked ||RBTN_C_Reponse.Checked || RBTN_D_Reponse.Checked)
            {
                One_is_selected = true;
            }
            return One_is_selected;

        }

        private bool validate_radiobutton(ref string message)
        {
            message = "bonne réponse non choisi";
            return VerifierRadiobutton();
        }

        private bool Validate_question(ref string message)
        {
            message = "question vide";
            return !string.IsNullOrWhiteSpace(RTBX_Question.Text);
        }

        private bool Validate_A_Reponse(ref string message)
        {
            message = "Reponse manquante";
            return !string.IsNullOrWhiteSpace(RTBX_A_Reponse.Text);
        }

        private bool Validate_B_Reponse(ref string message)
        {
            message = "Reponse manquante";
            return !string.IsNullOrWhiteSpace(RTBX_B_Reponse.Text);
        }

        private bool Validate_C_Reponse(ref string message)
        {
            message = "Reponse manquante";
            return !string.IsNullOrWhiteSpace(RTBX_C_Reponse.Text);
        }

        private bool Validate_D_Reponse(ref string message)
        {
            message = "Reponse manquante";
            return !string.IsNullOrWhiteSpace(RTBX_D_Reponse.Text);
        }


        #endregion

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            AjouterlaQuestion();
            this.Close();
        }

        private void BTN_Ajouterautre_Click(object sender, EventArgs e)
        {
            AjouterlaQuestion();
            RTBX_Question.Text = "";
            RTBX_A_Reponse.Text = "";
            RTBX_B_Reponse.Text = "";
            RTBX_C_Reponse.Text = "";
            RTBX_D_Reponse.Text = "";
            RBTN_A_Reponse.Checked = false;
            RBTN_B_Reponse.Checked = false;
            RBTN_C_Reponse.Checked = false;
            RBTN_D_Reponse.Checked = false;
            this.Refresh();
        }

        private void RTBX_Question_TextChanged(object sender, EventArgs e)
        {
            if (validation.FormValid())
            {
                BTN_Ajouter.Enabled = true;
                BTN_Ajouterautre.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled =false;
                BTN_Ajouterautre.Enabled = false;

            }
        }

        private void RTBX_A_Reponse_TextChanged(object sender, EventArgs e)
        {
            if (validation.FormValid())
            {
                BTN_Ajouter.Enabled = true;
                BTN_Ajouterautre.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
                BTN_Ajouterautre.Enabled = false;

            }
        }

        private void RTBX_B_Reponse_TextChanged(object sender, EventArgs e)
        {
            if (validation.FormValid())
            {
                BTN_Ajouter.Enabled = true;
                BTN_Ajouterautre.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
                BTN_Ajouterautre.Enabled = false;

            }
        }

        private void RTBX_C_Reponse_TextChanged(object sender, EventArgs e)
        {
            if (validation.FormValid())
            {
                BTN_Ajouter.Enabled = true;
                BTN_Ajouterautre.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
                BTN_Ajouterautre.Enabled = false;

            }
        }

        private void RTBX_D_Reponse_TextChanged(object sender, EventArgs e)
        {
            if (validation.FormValid())
            {
                BTN_Ajouter.Enabled = true;
                BTN_Ajouterautre.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
                BTN_Ajouterautre.Enabled = false;

            }
        }

      
    }
}
