namespace TP2_Base_de_données.Custom_Controls
{
    partial class Questionnaire
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.RTBX_Question = new System.Windows.Forms.RichTextBox();
            this.RBTN_B_Reponse = new System.Windows.Forms.RadioButton();
            this.RBTN_C_Reponse = new System.Windows.Forms.RadioButton();
            this.RBTN_D_Reponse = new System.Windows.Forms.RadioButton();
            this.RBTN_A_Reponse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RTBX_A_Reponse = new System.Windows.Forms.RichTextBox();
            this.RTBX_B_Reponse = new System.Windows.Forms.RichTextBox();
            this.RTBX_C_Reponse = new System.Windows.Forms.RichTextBox();
            this.RTBX_D_Reponse = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Repondre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBX_Question
            // 
            this.RTBX_Question.Location = new System.Drawing.Point(0, 20);
            this.RTBX_Question.Margin = new System.Windows.Forms.Padding(2);
            this.RTBX_Question.Name = "RTBX_Question";
            this.RTBX_Question.ReadOnly = true;
            this.RTBX_Question.Size = new System.Drawing.Size(376, 145);
            this.RTBX_Question.TabIndex = 6;
            this.RTBX_Question.Text = "";
            // 
            // RBTN_B_Reponse
            // 
            this.RBTN_B_Reponse.AutoSize = true;
            this.RBTN_B_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_B_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_B_Reponse.Location = new System.Drawing.Point(6, 232);
            this.RBTN_B_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_B_Reponse.Name = "RBTN_B_Reponse";
            this.RBTN_B_Reponse.Size = new System.Drawing.Size(37, 22);
            this.RBTN_B_Reponse.TabIndex = 10;
            this.RBTN_B_Reponse.TabStop = true;
            this.RBTN_B_Reponse.Text = "B";
            this.RBTN_B_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_B_Reponse.UseVisualStyleBackColor = true;
            this.RBTN_B_Reponse.CheckedChanged += new System.EventHandler(this.RBTN_Reponse_CheckedChanged);
            // 
            // RBTN_C_Reponse
            // 
            this.RBTN_C_Reponse.AutoSize = true;
            this.RBTN_C_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_C_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_C_Reponse.Location = new System.Drawing.Point(5, 273);
            this.RBTN_C_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_C_Reponse.Name = "RBTN_C_Reponse";
            this.RBTN_C_Reponse.Size = new System.Drawing.Size(38, 22);
            this.RBTN_C_Reponse.TabIndex = 9;
            this.RBTN_C_Reponse.TabStop = true;
            this.RBTN_C_Reponse.Text = "C";
            this.RBTN_C_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_C_Reponse.UseVisualStyleBackColor = true;
            this.RBTN_C_Reponse.CheckedChanged += new System.EventHandler(this.RBTN_Reponse_CheckedChanged);
            // 
            // RBTN_D_Reponse
            // 
            this.RBTN_D_Reponse.AutoSize = true;
            this.RBTN_D_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_D_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_D_Reponse.Location = new System.Drawing.Point(5, 314);
            this.RBTN_D_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_D_Reponse.Name = "RBTN_D_Reponse";
            this.RBTN_D_Reponse.Size = new System.Drawing.Size(38, 22);
            this.RBTN_D_Reponse.TabIndex = 8;
            this.RBTN_D_Reponse.TabStop = true;
            this.RBTN_D_Reponse.Text = "D";
            this.RBTN_D_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_D_Reponse.UseVisualStyleBackColor = true;
            this.RBTN_D_Reponse.CheckedChanged += new System.EventHandler(this.RBTN_Reponse_CheckedChanged);
            // 
            // RBTN_A_Reponse
            // 
            this.RBTN_A_Reponse.AutoSize = true;
            this.RBTN_A_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_A_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_A_Reponse.Location = new System.Drawing.Point(7, 191);
            this.RBTN_A_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_A_Reponse.Name = "RBTN_A_Reponse";
            this.RBTN_A_Reponse.Size = new System.Drawing.Size(36, 22);
            this.RBTN_A_Reponse.TabIndex = 7;
            this.RBTN_A_Reponse.TabStop = true;
            this.RBTN_A_Reponse.Text = "A";
            this.RBTN_A_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_A_Reponse.UseVisualStyleBackColor = true;
            this.RBTN_A_Reponse.CheckedChanged += new System.EventHandler(this.RBTN_Reponse_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Question";
            // 
            // RTBX_A_Reponse
            // 
            this.RTBX_A_Reponse.Location = new System.Drawing.Point(48, 191);
            this.RTBX_A_Reponse.Name = "RTBX_A_Reponse";
            this.RTBX_A_Reponse.ReadOnly = true;
            this.RTBX_A_Reponse.Size = new System.Drawing.Size(312, 35);
            this.RTBX_A_Reponse.TabIndex = 12;
            this.RTBX_A_Reponse.Text = "";
            // 
            // RTBX_B_Reponse
            // 
            this.RTBX_B_Reponse.Location = new System.Drawing.Point(48, 232);
            this.RTBX_B_Reponse.Name = "RTBX_B_Reponse";
            this.RTBX_B_Reponse.ReadOnly = true;
            this.RTBX_B_Reponse.Size = new System.Drawing.Size(312, 35);
            this.RTBX_B_Reponse.TabIndex = 13;
            this.RTBX_B_Reponse.Text = "";
            // 
            // RTBX_C_Reponse
            // 
            this.RTBX_C_Reponse.Location = new System.Drawing.Point(48, 273);
            this.RTBX_C_Reponse.Name = "RTBX_C_Reponse";
            this.RTBX_C_Reponse.ReadOnly = true;
            this.RTBX_C_Reponse.Size = new System.Drawing.Size(312, 35);
            this.RTBX_C_Reponse.TabIndex = 14;
            this.RTBX_C_Reponse.Text = "";
            // 
            // RTBX_D_Reponse
            // 
            this.RTBX_D_Reponse.Location = new System.Drawing.Point(48, 314);
            this.RTBX_D_Reponse.Name = "RTBX_D_Reponse";
            this.RTBX_D_Reponse.ReadOnly = true;
            this.RTBX_D_Reponse.Size = new System.Drawing.Size(312, 35);
            this.RTBX_D_Reponse.TabIndex = 15;
            this.RTBX_D_Reponse.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Réponses";
            // 
            // BTN_Repondre
            // 
            this.BTN_Repondre.Enabled = false;
            this.BTN_Repondre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Repondre.Location = new System.Drawing.Point(119, 363);
            this.BTN_Repondre.Name = "BTN_Repondre";
            this.BTN_Repondre.Size = new System.Drawing.Size(121, 42);
            this.BTN_Repondre.TabIndex = 17;
            this.BTN_Repondre.Text = "Répondre";
            this.BTN_Repondre.UseVisualStyleBackColor = true;
            this.BTN_Repondre.Click += new System.EventHandler(this.BTN_Repondre_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.BTN_Repondre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTBX_D_Reponse);
            this.Controls.Add(this.RTBX_C_Reponse);
            this.Controls.Add(this.RTBX_B_Reponse);
            this.Controls.Add(this.RTBX_A_Reponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBTN_B_Reponse);
            this.Controls.Add(this.RBTN_C_Reponse);
            this.Controls.Add(this.RBTN_D_Reponse);
            this.Controls.Add(this.RBTN_A_Reponse);
            this.Controls.Add(this.RTBX_Question);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Questionnaire";
            this.Size = new System.Drawing.Size(376, 418);
            this.Load += new System.EventHandler(this.Questionnaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBX_Question;
        private System.Windows.Forms.RadioButton RBTN_B_Reponse;
        private System.Windows.Forms.RadioButton RBTN_C_Reponse;
        private System.Windows.Forms.RadioButton RBTN_D_Reponse;
        private System.Windows.Forms.RadioButton RBTN_A_Reponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTBX_A_Reponse;
        private System.Windows.Forms.RichTextBox RTBX_B_Reponse;
        private System.Windows.Forms.RichTextBox RTBX_C_Reponse;
        private System.Windows.Forms.RichTextBox RTBX_D_Reponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Repondre;
    }
}
