namespace TP2_Base_de_données
{
    partial class Jeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PB_PointsInfos = new System.Windows.Forms.ProgressBar();
            this.LAB_PointsInfos = new System.Windows.Forms.Label();
            this.LAB_NomCatInfos = new System.Windows.Forms.Label();
            this.BTN_Tourner = new System.Windows.Forms.Button();
            this.LAB_NomCatRoue = new System.Windows.Forms.Label();
            this.P_Roue = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.P_PointsRestants = new System.Windows.Forms.Panel();
            this.LAB_Info = new System.Windows.Forms.Label();
            this.LAB_PremierRang = new System.Windows.Forms.Label();
            this.LAB_DeuxiemeRang = new System.Windows.Forms.Label();
            this.LAB_TroisiemeRang = new System.Windows.Forms.Label();
            this.P_Rangs = new System.Windows.Forms.Panel();
            this.BW_TimerRoue = new System.ComponentModel.BackgroundWorker();
            this.BW_TimerInfos = new System.ComponentModel.BackgroundWorker();
            this.BTN_MenuPrincipal = new System.Windows.Forms.Button();
            this.BTN_Classement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBX_Instructions = new System.Windows.Forms.RichTextBox();
            this.CC_Choisir = new Custom_Controls.ChoisirCategorie();
            this.Q_Questionnaire = new Custom_Controls.Questionnaire();
            this.LJ_Participants = new Custom_Controls.ListeJoueur();
            this.P_PointsRestants.SuspendLayout();
            this.P_Rangs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Joueurs";
            // 
            // PB_PointsInfos
            // 
            this.PB_PointsInfos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PB_PointsInfos.Location = new System.Drawing.Point(12, 80);
            this.PB_PointsInfos.Maximum = 5;
            this.PB_PointsInfos.Name = "PB_PointsInfos";
            this.PB_PointsInfos.Size = new System.Drawing.Size(195, 23);
            this.PB_PointsInfos.Step = 1;
            this.PB_PointsInfos.TabIndex = 6;
            // 
            // LAB_PointsInfos
            // 
            this.LAB_PointsInfos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LAB_PointsInfos.AutoSize = true;
            this.LAB_PointsInfos.Location = new System.Drawing.Point(213, 82);
            this.LAB_PointsInfos.Name = "LAB_PointsInfos";
            this.LAB_PointsInfos.Size = new System.Drawing.Size(36, 18);
            this.LAB_PointsInfos.TabIndex = 7;
            this.LAB_PointsInfos.Text = "0 / 5";
            // 
            // LAB_NomCatInfos
            // 
            this.LAB_NomCatInfos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LAB_NomCatInfos.AutoSize = true;
            this.LAB_NomCatInfos.Location = new System.Drawing.Point(9, 59);
            this.LAB_NomCatInfos.Name = "LAB_NomCatInfos";
            this.LAB_NomCatInfos.Size = new System.Drawing.Size(72, 18);
            this.LAB_NomCatInfos.TabIndex = 8;
            this.LAB_NomCatInfos.Text = "Categorie";
            // 
            // BTN_Tourner
            // 
            this.BTN_Tourner.Enabled = false;
            this.BTN_Tourner.Location = new System.Drawing.Point(684, 128);
            this.BTN_Tourner.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Tourner.Name = "BTN_Tourner";
            this.BTN_Tourner.Size = new System.Drawing.Size(87, 35);
            this.BTN_Tourner.TabIndex = 19;
            this.BTN_Tourner.Text = "Tourner";
            this.BTN_Tourner.UseVisualStyleBackColor = true;
            this.BTN_Tourner.Click += new System.EventHandler(this.BTN_Tourner_Click);
            // 
            // LAB_NomCatRoue
            // 
            this.LAB_NomCatRoue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LAB_NomCatRoue.Location = new System.Drawing.Point(603, 49);
            this.LAB_NomCatRoue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_NomCatRoue.Name = "LAB_NomCatRoue";
            this.LAB_NomCatRoue.Size = new System.Drawing.Size(250, 31);
            this.LAB_NomCatRoue.TabIndex = 18;
            this.LAB_NomCatRoue.Text = "????";
            this.LAB_NomCatRoue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Roue
            // 
            this.P_Roue.BackColor = System.Drawing.SystemColors.Control;
            this.P_Roue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_Roue.Location = new System.Drawing.Point(599, 22);
            this.P_Roue.Name = "P_Roue";
            this.P_Roue.Size = new System.Drawing.Size(258, 149);
            this.P_Roue.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(596, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Catégorie";
            // 
            // P_PointsRestants
            // 
            this.P_PointsRestants.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.P_PointsRestants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_PointsRestants.Controls.Add(this.LAB_Info);
            this.P_PointsRestants.Controls.Add(this.LAB_NomCatInfos);
            this.P_PointsRestants.Controls.Add(this.PB_PointsInfos);
            this.P_PointsRestants.Controls.Add(this.LAB_PointsInfos);
            this.P_PointsRestants.Location = new System.Drawing.Point(5, 294);
            this.P_PointsRestants.Name = "P_PointsRestants";
            this.P_PointsRestants.Size = new System.Drawing.Size(260, 111);
            this.P_PointsRestants.TabIndex = 22;
            this.P_PointsRestants.Visible = false;
            // 
            // LAB_Info
            // 
            this.LAB_Info.AutoSize = true;
            this.LAB_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Info.ForeColor = System.Drawing.Color.SeaGreen;
            this.LAB_Info.Location = new System.Drawing.Point(20, 12);
            this.LAB_Info.MaximumSize = new System.Drawing.Size(220, 0);
            this.LAB_Info.Name = "LAB_Info";
            this.LAB_Info.Size = new System.Drawing.Size(216, 36);
            this.LAB_Info.TabIndex = 22;
            this.LAB_Info.Text = "Il ne manque que X points à ALIAS pour gagner en";
            this.LAB_Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LAB_PremierRang
            // 
            this.LAB_PremierRang.AutoSize = true;
            this.LAB_PremierRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_PremierRang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(196)))), ((int)(((byte)(10)))));
            this.LAB_PremierRang.Location = new System.Drawing.Point(23, 14);
            this.LAB_PremierRang.Name = "LAB_PremierRang";
            this.LAB_PremierRang.Size = new System.Drawing.Size(150, 18);
            this.LAB_PremierRang.TabIndex = 23;
            this.LAB_PremierRang.Text = "1er : ALIAS (0 / 20)";
            this.LAB_PremierRang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_DeuxiemeRang
            // 
            this.LAB_DeuxiemeRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_DeuxiemeRang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(184)))), ((int)(((byte)(201)))));
            this.LAB_DeuxiemeRang.Location = new System.Drawing.Point(1, 44);
            this.LAB_DeuxiemeRang.Name = "LAB_DeuxiemeRang";
            this.LAB_DeuxiemeRang.Size = new System.Drawing.Size(258, 18);
            this.LAB_DeuxiemeRang.TabIndex = 24;
            this.LAB_DeuxiemeRang.Text = "2e  : ALIAS (0 / 20)";
            this.LAB_DeuxiemeRang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_TroisiemeRang
            // 
            this.LAB_TroisiemeRang.AutoSize = true;
            this.LAB_TroisiemeRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_TroisiemeRang.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LAB_TroisiemeRang.Location = new System.Drawing.Point(87, 74);
            this.LAB_TroisiemeRang.Name = "LAB_TroisiemeRang";
            this.LAB_TroisiemeRang.Size = new System.Drawing.Size(149, 18);
            this.LAB_TroisiemeRang.TabIndex = 25;
            this.LAB_TroisiemeRang.Text = "3e  : ALIAS (0 / 20)";
            this.LAB_TroisiemeRang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Rangs
            // 
            this.P_Rangs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.P_Rangs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_Rangs.Controls.Add(this.LAB_TroisiemeRang);
            this.P_Rangs.Controls.Add(this.LAB_DeuxiemeRang);
            this.P_Rangs.Controls.Add(this.LAB_PremierRang);
            this.P_Rangs.Location = new System.Drawing.Point(5, 294);
            this.P_Rangs.Name = "P_Rangs";
            this.P_Rangs.Size = new System.Drawing.Size(260, 111);
            this.P_Rangs.TabIndex = 23;
            // 
            // BW_TimerRoue
            // 
            this.BW_TimerRoue.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_TimerRoue_DoWork);
            // 
            // BW_TimerInfos
            // 
            this.BW_TimerInfos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_TimerInfos_DoWork);
            // 
            // BTN_MenuPrincipal
            // 
            this.BTN_MenuPrincipal.Location = new System.Drawing.Point(668, 320);
            this.BTN_MenuPrincipal.Name = "BTN_MenuPrincipal";
            this.BTN_MenuPrincipal.Size = new System.Drawing.Size(121, 38);
            this.BTN_MenuPrincipal.TabIndex = 27;
            this.BTN_MenuPrincipal.Text = "Menu principal";
            this.BTN_MenuPrincipal.UseVisualStyleBackColor = true;
            this.BTN_MenuPrincipal.Click += new System.EventHandler(this.BTN_MenuPrincipal_Click);
            // 
            // BTN_Classement
            // 
            this.BTN_Classement.Location = new System.Drawing.Point(668, 367);
            this.BTN_Classement.Name = "BTN_Classement";
            this.BTN_Classement.Size = new System.Drawing.Size(121, 38);
            this.BTN_Classement.TabIndex = 28;
            this.BTN_Classement.Text = "Classement";
            this.BTN_Classement.UseVisualStyleBackColor = true;
            this.BTN_Classement.Click += new System.EventHandler(this.BTN_Classement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Instructions";
            // 
            // RTBX_Instructions
            // 
            this.RTBX_Instructions.Cursor = System.Windows.Forms.Cursors.Default;
            this.RTBX_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBX_Instructions.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RTBX_Instructions.Location = new System.Drawing.Point(599, 197);
            this.RTBX_Instructions.Name = "RTBX_Instructions";
            this.RTBX_Instructions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTBX_Instructions.ShowSelectionMargin = true;
            this.RTBX_Instructions.Size = new System.Drawing.Size(258, 117);
            this.RTBX_Instructions.TabIndex = 30;
            this.RTBX_Instructions.Text = "";
            // 
            // CC_Choisir
            // 
            this.CC_Choisir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CC_Choisir.CategorieEstChoisie = null;
            this.CC_Choisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_Choisir.Location = new System.Drawing.Point(599, 22);
            this.CC_Choisir.Name = "CC_Choisir";
            this.CC_Choisir.Size = new System.Drawing.Size(258, 149);
            this.CC_Choisir.TabIndex = 32;
            this.CC_Choisir.Visible = false;
            // 
            // Q_Questionnaire
            // 
            this.Q_Questionnaire.ARepondre = null;
            this.Q_Questionnaire.BackColor = System.Drawing.SystemColors.Control;
            this.Q_Questionnaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q_Questionnaire.Location = new System.Drawing.Point(271, 2);
            this.Q_Questionnaire.Name = "Q_Questionnaire";
            this.Q_Questionnaire.Size = new System.Drawing.Size(322, 403);
            this.Q_Questionnaire.TabIndex = 24;
            // 
            // LJ_Participants
            // 
            this.LJ_Participants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LJ_Participants.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LJ_Participants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LJ_Participants.Location = new System.Drawing.Point(5, 22);
            this.LJ_Participants.MinimumSize = new System.Drawing.Size(259, 266);
            this.LJ_Participants.Name = "LJ_Participants";
            this.LJ_Participants.SelectedIndex = -1;
            this.LJ_Participants.Size = new System.Drawing.Size(259, 266);
            this.LJ_Participants.TabIndex = 5;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 413);
            this.Controls.Add(this.CC_Choisir);
            this.Controls.Add(this.RTBX_Instructions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Classement);
            this.Controls.Add(this.BTN_MenuPrincipal);
            this.Controls.Add(this.Q_Questionnaire);
            this.Controls.Add(this.BTN_Tourner);
            this.Controls.Add(this.P_Rangs);
            this.Controls.Add(this.P_PointsRestants);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LAB_NomCatRoue);
            this.Controls.Add(this.P_Roue);
            this.Controls.Add(this.LJ_Participants);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Jeu";
            this.ShowIcon = false;
            this.Text = "Jeu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jeu_FormClosing);
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.P_PointsRestants.ResumeLayout(false);
            this.P_PointsRestants.PerformLayout();
            this.P_Rangs.ResumeLayout(false);
            this.P_Rangs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Custom_Controls.ListeJoueur LJ_Participants;
        private System.Windows.Forms.ProgressBar PB_PointsInfos;
        private System.Windows.Forms.Label LAB_PointsInfos;
        private System.Windows.Forms.Label LAB_NomCatInfos;
        private System.Windows.Forms.Button BTN_Tourner;
        private System.Windows.Forms.Label LAB_NomCatRoue;
        private System.Windows.Forms.Panel P_Roue;
        private System.Windows.Forms.Panel P_PointsRestants;
        private System.Windows.Forms.Label LAB_Info;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LAB_PremierRang;
        private System.Windows.Forms.Label LAB_DeuxiemeRang;
        private System.Windows.Forms.Label LAB_TroisiemeRang;
        private System.Windows.Forms.Panel P_Rangs;
        private System.ComponentModel.BackgroundWorker BW_TimerRoue;
        private System.ComponentModel.BackgroundWorker BW_TimerInfos;
        private Custom_Controls.Questionnaire Q_Questionnaire;
        private System.Windows.Forms.Button BTN_MenuPrincipal;
        private System.Windows.Forms.Button BTN_Classement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBX_Instructions;
        private Custom_Controls.ChoisirCategorie CC_Choisir;
    }
}