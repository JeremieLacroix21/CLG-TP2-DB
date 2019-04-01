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
            this.BTN_Ajouterjoueur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_jouer
            // 
            this.BTN_jouer.Location = new System.Drawing.Point(12, 12);
            this.BTN_jouer.Name = "BTN_jouer";
            this.BTN_jouer.Size = new System.Drawing.Size(279, 97);
            this.BTN_jouer.TabIndex = 0;
            this.BTN_jouer.Text = "commencer partie";
            this.BTN_jouer.UseVisualStyleBackColor = true;
            this.BTN_jouer.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 97);
            this.button2.TabIndex = 2;
            this.button2.Text = "réglages";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTN_AjouterQuestion
            // 
            this.BTN_AjouterQuestion.Location = new System.Drawing.Point(12, 115);
            this.BTN_AjouterQuestion.Name = "BTN_AjouterQuestion";
            this.BTN_AjouterQuestion.Size = new System.Drawing.Size(279, 97);
            this.BTN_AjouterQuestion.TabIndex = 3;
            this.BTN_AjouterQuestion.Text = "Ajouter question";
            this.BTN_AjouterQuestion.UseVisualStyleBackColor = true;
            this.BTN_AjouterQuestion.Click += new System.EventHandler(this.BTN_AjouterQuestion_Click);
            // 
            // BTN_Ajouterjoueur
            // 
            this.BTN_Ajouterjoueur.Location = new System.Drawing.Point(297, 12);
            this.BTN_Ajouterjoueur.Name = "BTN_Ajouterjoueur";
            this.BTN_Ajouterjoueur.Size = new System.Drawing.Size(279, 97);
            this.BTN_Ajouterjoueur.TabIndex = 4;
            this.BTN_Ajouterjoueur.Text = "configurer joueurs";
            this.BTN_Ajouterjoueur.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 224);
            this.Controls.Add(this.BTN_Ajouterjoueur);
            this.Controls.Add(this.BTN_AjouterQuestion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_jouer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_jouer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_AjouterQuestion;
        private System.Windows.Forms.Button BTN_Ajouterjoueur;
    }
}