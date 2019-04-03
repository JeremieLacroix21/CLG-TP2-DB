using Global;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Objets_BD;
using System.Drawing;
using System.Linq;

namespace Custom_Controls
{
    public partial class Questionnaire : UserControl
    {
        private bool _Init = true;
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

            RTBX_Question.GotFocus += (s, evArgs) => RTBX_Reponse_GotFocus(RTBX_A_Reponse, evArgs);
            InitReponses();
        }

        private void Questionnaire_Load(object sender, EventArgs e)
        {
            Choisie = null;
            _Init = false;

            InitQuestionnaire();
        }

        private void RTBX_Reponse_GotFocus(object sender, EventArgs e)
        {
            int iFocusedRTBX = _ReponsesRTBX.FindIndex(r => r == sender as RichTextBox);
            _ReponsesRBTN[iFocusedRTBX].Focus();
        }

        private void SetQuestion(Question value)
        {
            _Question = value;
            if (!_Init)
                InitQuestionnaire();
        }

        private void InitReponses()
        {
            _ReponsesRTBX.AddRange(RTBX_A_Reponse, RTBX_B_Reponse, RTBX_C_Reponse, RTBX_D_Reponse);
            _ReponsesRBTN.AddRange(RBTN_A_Reponse, RBTN_B_Reponse, RBTN_C_Reponse, RBTN_D_Reponse);
            foreach (var rtbx in _ReponsesRTBX)
            {
                rtbx.GotFocus += RTBX_Reponse_GotFocus;
            }
        }

        private void InitQuestionnaire()
        {
            bool aucuneQuestion = _Question == null;

            Choisie = null;
            BTN_Repondre.Enabled = false;
            RTBX_Question.Text = aucuneQuestion ? "" : _Question.Enonce;
            for (int i = 0; i < Question.NB_REPONSES; ++i) 
            {
                _ReponsesRTBX[i].Text = aucuneQuestion ?  "" : _Question.Reponses[i].Description;
                _ReponsesRBTN[i].Checked = false;
                this.Enabled = !aucuneQuestion;
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
