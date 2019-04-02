namespace TP2_Base_de_données
{
    partial class JoueurManager
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
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.LBL_Joueur = new System.Windows.Forms.Label();
            this.listeJoueur = new Custom_Controls.ListeJoueur();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(12, 29);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(100, 22);
            this.TBX_Nom.TabIndex = 0;
            // 
            // LBL_Joueur
            // 
            this.LBL_Joueur.AutoSize = true;
            this.LBL_Joueur.Location = new System.Drawing.Point(9, 9);
            this.LBL_Joueur.Name = "LBL_Joueur";
            this.LBL_Joueur.Size = new System.Drawing.Size(85, 17);
            this.LBL_Joueur.TabIndex = 1;
            this.LBL_Joueur.Text = "Nom joueur:";
            // 
            // listeJoueur
            // 
            this.listeJoueur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listeJoueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listeJoueur.Location = new System.Drawing.Point(135, 13);
            this.listeJoueur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listeJoueur.Name = "listeJoueur";
            this.listeJoueur.SelectedIndex = -1;
            this.listeJoueur.Size = new System.Drawing.Size(232, 206);
            this.listeJoueur.TabIndex = 2;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(12, 57);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(100, 27);
            this.BTN_Ajouter.TabIndex = 3;
            this.BTN_Ajouter.Text = "Ajouter joueur";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // JoueurManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 232);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.listeJoueur);
            this.Controls.Add(this.LBL_Joueur);
            this.Controls.Add(this.TBX_Nom);
            this.Name = "JoueurManager";
            this.Text = "JoueurManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.Label LBL_Joueur;
        private Custom_Controls.ListeJoueur listeJoueur;
        private System.Windows.Forms.Button BTN_Ajouter;
    }
}