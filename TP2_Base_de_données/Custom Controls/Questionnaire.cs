using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Base_de_données.Objets_BD;

namespace TP2_Base_de_données.Custom_Controls
{
    public partial class Questionnaire : UserControl
    {
        private Question _Question;
        
        /// <summary>La question à laquelle l'utilisateur devra répondre</summary>
        /// <remark>Changer la valeur de cette propriété mettra le questionnaire à jour automatiquement</remark>
        public Question ARepondre { get => return _Question; set => SetQuestion(value); }
        /// <summary>La réponse choisie par l'utilisateur</summary>
        public Reponse Choisie { get; private set; }
        /// <summary>Se produit quand le bouton Répondre est cliqué</summary>
        public event EventHandler RespondClicked;

        public Questionnaire()
        {
            InitializeComponent();
        }

        private void Questionnaire_Load(object sender, EventArgs e)
        {
            Choisie = null;
        }
        
        private void SetQuestion(Question value)
        {
            _Question = value;
            InitQuestionnaire();
        }

        private void InitQuestionnaire()
        {
            Choisie = null;
            BTN_Repondre.Enabled = false;
            RTBX_Question.Text = _Question.Enonce;
            RTBX_A_Reponse.Text = _Question.Reponses[0].Description;
            RTBX_B_Reponse.Text = _Question.Reponses[1].Description;
            RTBX_C_Reponse.Text = _Question.Reponses[2].Description;
            RTBX_D_Reponse.Text = _Question.Reponses[3].Description;
            RBTN_A_Reponse.Checked = false;
            RBTN_B_Reponse.Checked = false;
            RBTN_C_Reponse.Checked = false;
            RBTN_D_Reponse.Checked = false;
        }

        private void RBTN_Reponse_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Repondre.Enabled = RBTN_A_Reponse.Checked || RBTN_B_Reponse.Checked || RBTN_C_Reponse.Checked || RBTN_D_Reponse.Checked;
        }

        private void BTN_Repondre_Click(object sender, EventArgs e)
        {
            Choisie = RBTN_A_Reponse.Checked ? _Question.Reponses[0] :
                      RBTN_B_Reponse.Checked ? _Question.Reponses[1] :
                      RBTN_C_Reponse.Checked ? _Question.Reponses[2] :
                      _Question.Reponses[3];

            RespondClicked?.Invoke(sender, e);
        }
    }
}
