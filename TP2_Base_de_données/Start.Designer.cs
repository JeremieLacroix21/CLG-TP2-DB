namespace TP2_Base_de_données
{
    partial class Start
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
            this.BTN_jouer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_AjouterQuestion = new System.Windows.Forms.Button();
            this.BTN_Configurerjoueur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_jouer
            // 
            this.BTN_jouer.Enabled = false;
            this.BTN_jouer.Location = new System.Drawing.Point(9, 10);
            this.BTN_jouer.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_jouer.Name = "BTN_jouer";
            this.BTN_jouer.Size = new System.Drawing.Size(209, 79);
            this.BTN_jouer.TabIndex = 0;
            this.BTN_jouer.Text = "commencer partie";
            this.BTN_jouer.UseVisualStyleBackColor = true;
            this.BTN_jouer.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "classement";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTN_AjouterQuestion
            // 
            this.BTN_AjouterQuestion.Location = new System.Drawing.Point(9, 93);
            this.BTN_AjouterQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_AjouterQuestion.Name = "BTN_AjouterQuestion";
            this.BTN_AjouterQuestion.Size = new System.Drawing.Size(209, 79);
            this.BTN_AjouterQuestion.TabIndex = 3;
            this.BTN_AjouterQuestion.Text = "Ajouter question";
            this.BTN_AjouterQuestion.UseVisualStyleBackColor = true;
            this.BTN_AjouterQuestion.Click += new System.EventHandler(this.BTN_AjouterQuestion_Click);
            // 
            // BTN_Configurerjoueur
            // 
            this.BTN_Configurerjoueur.Location = new System.Drawing.Point(223, 10);
            this.BTN_Configurerjoueur.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Configurerjoueur.Name = "BTN_Configurerjoueur";
            this.BTN_Configurerjoueur.Size = new System.Drawing.Size(209, 79);
            this.BTN_Configurerjoueur.TabIndex = 4;
            this.BTN_Configurerjoueur.Text = "configurer joueurs";
            this.BTN_Configurerjoueur.UseVisualStyleBackColor = true;
            this.BTN_Configurerjoueur.Click += new System.EventHandler(this.BTN_Configurerjoueur_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 182);
            this.Controls.Add(this.BTN_Configurerjoueur);
            this.Controls.Add(this.BTN_AjouterQuestion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_jouer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_jouer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_AjouterQuestion;
        private System.Windows.Forms.Button BTN_Configurerjoueur;
    }
}