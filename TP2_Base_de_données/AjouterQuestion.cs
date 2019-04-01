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

            Close();
        }
    }
}
