using Global;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP2_Base_de_données.Objets_BD;

namespace TP2_Base_de_données.Custom_Controls
{
    public partial class Questionnaire : UserControl
    {
        private Question _Question;
        private readonly List<RichTextBox> _ReponsesRTBX = new List<RichTextBox>();
        private readonly List<RadioButton> _ReponsesRBTN = new List<RadioButton>();
        
        /// <summary>La question à laquelle l'utilisateur devra répondre</summary>
        /// <remark>Changer la valeur de cette propriété mettra le questionnaire à jour automatiquement</remark>
        public Question ARepondre { get => _Question; set => SetQuestion(value); }
        /// <summary>La réponse choisie par l'utilisateur</summary>
        public Reponse Choisie { get; private set; }
        /// <summary>Se produit quand le bouton Répondre est cliqué</summary>
        public event EventHandler RespondClicked;

        public Questionnaire()
        {
            InitializeComponent();
            _ReponsesRTBX.AddRange(RTBX_A_Reponse, RTBX_B_Reponse, RTBX_C_Reponse, RTBX_D_Reponse);
            _ReponsesRBTN.AddRange(RBTN_A_Reponse, RBTN_B_Reponse, RBTN_C_Reponse, RBTN_D_Reponse);
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
            for (int i = 0; i < Question.NB_REPONSES; ++i) 
            {
                _ReponsesRTBX[i].Text = _Question.Reponses[i].Description;
                _ReponsesRBTN[i].Checked = false;
            }
        }

        private void RBTN_Reponse_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Repondre.Enabled = _ReponsesRBTN.Exists(rbtn => rbtn.Checked); ;
        }

        private void BTN_Repondre_Click(object sender, EventArgs e)
        {
            int iCheckedRBTN = _ReponsesRBTN.FindIndex(rbtn => rbtn.Checked);
            Choisie = _Question.Reponses[iCheckedRBTN];

            RespondClicked?.Invoke(sender, e);
        }
    }
}
