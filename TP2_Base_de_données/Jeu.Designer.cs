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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PB_PointsInfos = new System.Windows.Forms.ProgressBar();
            this.LAB_PointsInfos = new System.Windows.Forms.Label();
            this.LAB_NomCatInfos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
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
            this.LJ_Participants = new TP2_Base_de_données.Custom_Controls.ListeJoueur();
            this.P_PointsRestants.SuspendLayout();
            this.P_Rangs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Joueurs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PB_PointsInfos
            // 
            this.PB_PointsInfos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PB_PointsInfos.Location = new System.Drawing.Point(10, 81);
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
            this.LAB_PointsInfos.Location = new System.Drawing.Point(211, 83);
            this.LAB_PointsInfos.Name = "LAB_PointsInfos";
            this.LAB_PointsInfos.Size = new System.Drawing.Size(36, 18);
            this.LAB_PointsInfos.TabIndex = 7;
            this.LAB_PointsInfos.Text = "0 / 5";
            // 
            // LAB_NomCatInfos
            // 
            this.LAB_NomCatInfos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LAB_NomCatInfos.AutoSize = true;
            this.LAB_NomCatInfos.Location = new System.Drawing.Point(7, 60);
            this.LAB_NomCatInfos.Name = "LAB_NomCatInfos";
            this.LAB_NomCatInfos.Size = new System.Drawing.Size(72, 18);
            this.LAB_NomCatInfos.TabIndex = 8;
            this.LAB_NomCatInfos.Text = "Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Geographie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "0 / 5";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(108, 431);
            this.progressBar2.Maximum = 5;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(166, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 9;
            this.progressBar2.Value = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Geographie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "0 / 5";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(108, 525);
            this.progressBar3.Maximum = 5;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(166, 23);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 15;
            this.progressBar3.Value = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Geographie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "0 / 5";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(108, 478);
            this.progressBar4.Maximum = 5;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(166, 23);
            this.progressBar4.Step = 1;
            this.progressBar4.TabIndex = 12;
            this.progressBar4.Value = 2;
            // 
            // BTN_Tourner
            // 
            this.BTN_Tourner.Enabled = false;
            this.BTN_Tourner.Location = new System.Drawing.Point(339, 128);
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
            this.LAB_NomCatRoue.Location = new System.Drawing.Point(258, 49);
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
            this.P_Roue.Location = new System.Drawing.Point(254, 22);
            this.P_Roue.Name = "P_Roue";
            this.P_Roue.Size = new System.Drawing.Size(258, 149);
            this.P_Roue.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 1);
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
            this.P_PointsRestants.Location = new System.Drawing.Point(254, 173);
            this.P_PointsRestants.Name = "P_PointsRestants";
            this.P_PointsRestants.Size = new System.Drawing.Size(258, 111);
            this.P_PointsRestants.TabIndex = 22;
            this.P_PointsRestants.Visible = false;
            // 
            // LAB_Info
            // 
            this.LAB_Info.AutoSize = true;
            this.LAB_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Info.ForeColor = System.Drawing.Color.SeaGreen;
            this.LAB_Info.Location = new System.Drawing.Point(19, 12);
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
            this.LAB_PremierRang.Location = new System.Drawing.Point(20, 14);
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
            this.LAB_DeuxiemeRang.Location = new System.Drawing.Point(-2, 44);
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
            this.LAB_TroisiemeRang.Location = new System.Drawing.Point(84, 74);
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
            this.P_Rangs.Location = new System.Drawing.Point(254, 173);
            this.P_Rangs.Name = "P_Rangs";
            this.P_Rangs.Size = new System.Drawing.Size(258, 111);
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
            // LJ_Participants
            // 
            this.LJ_Participants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LJ_Participants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LJ_Participants.Location = new System.Drawing.Point(3, 22);
            this.LJ_Participants.Margin = new System.Windows.Forms.Padding(4);
            this.LJ_Participants.Name = "LJ_Participants";
            this.LJ_Participants.SelectedIndex = -1;
            this.LJ_Participants.Size = new System.Drawing.Size(244, 262);
            this.LJ_Participants.TabIndex = 5;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 644);
            this.Controls.Add(this.BTN_Tourner);
            this.Controls.Add(this.P_Rangs);
            this.Controls.Add(this.P_PointsRestants);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LAB_NomCatRoue);
            this.Controls.Add(this.P_Roue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.LJ_Participants);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Jeu";
            this.Text = "Jeu";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Custom_Controls.ListeJoueur LJ_Participants;
        private System.Windows.Forms.ProgressBar PB_PointsInfos;
        private System.Windows.Forms.Label LAB_PointsInfos;
        private System.Windows.Forms.Label LAB_NomCatInfos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar4;
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
    }
}