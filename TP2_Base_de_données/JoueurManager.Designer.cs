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
            this.TBX_Alias = new System.Windows.Forms.TextBox();
            this.LBL_Joueur = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.TBX_Prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.CLB_joueurs = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Accepter = new System.Windows.Forms.Button();
            this.BTN_supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBX_Alias
            // 
            this.TBX_Alias.Location = new System.Drawing.Point(9, 24);
            this.TBX_Alias.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Alias.Name = "TBX_Alias";
            this.TBX_Alias.Size = new System.Drawing.Size(76, 20);
            this.TBX_Alias.TabIndex = 0;
            this.TBX_Alias.TextChanged += new System.EventHandler(this.TBX_TextChanged);
            // 
            // LBL_Joueur
            // 
            this.LBL_Joueur.AutoSize = true;
            this.LBL_Joueur.Location = new System.Drawing.Point(7, 7);
            this.LBL_Joueur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Joueur.Name = "LBL_Joueur";
            this.LBL_Joueur.Size = new System.Drawing.Size(35, 13);
            this.LBL_Joueur.TabIndex = 1;
            this.LBL_Joueur.Text = "Alias :";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(9, 119);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 22);
            this.BTN_Ajouter.TabIndex = 3;
            this.BTN_Ajouter.Text = "Ajouter joueur";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // TBX_Prenom
            // 
            this.TBX_Prenom.Location = new System.Drawing.Point(9, 60);
            this.TBX_Prenom.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Prenom.Name = "TBX_Prenom";
            this.TBX_Prenom.Size = new System.Drawing.Size(76, 20);
            this.TBX_Prenom.TabIndex = 5;
            this.TBX_Prenom.TextChanged += new System.EventHandler(this.TBX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prénom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom de famille:";
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(9, 97);
            this.TBX_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(76, 20);
            this.TBX_Nom.TabIndex = 7;
            this.TBX_Nom.TextChanged += new System.EventHandler(this.TBX_TextChanged);
            // 
            // CLB_joueurs
            // 
            this.CLB_joueurs.CheckOnClick = true;
            this.CLB_joueurs.FormattingEnabled = true;
            this.CLB_joueurs.Location = new System.Drawing.Point(102, 24);
            this.CLB_joueurs.Margin = new System.Windows.Forms.Padding(2);
            this.CLB_joueurs.Name = "CLB_joueurs";
            this.CLB_joueurs.Size = new System.Drawing.Size(175, 154);
            this.CLB_joueurs.TabIndex = 9;
            this.CLB_joueurs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_joueurs_ItemCheck);
            this.CLB_joueurs.SelectedIndexChanged += new System.EventHandler(this.CLB_joueurs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sélectionner 2-4 joueurs:";
            // 
            // BTN_Accepter
            // 
            this.BTN_Accepter.Location = new System.Drawing.Point(201, 184);
            this.BTN_Accepter.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Accepter.Name = "BTN_Accepter";
            this.BTN_Accepter.Size = new System.Drawing.Size(75, 22);
            this.BTN_Accepter.TabIndex = 11;
            this.BTN_Accepter.Text = "Accepter";
            this.BTN_Accepter.UseVisualStyleBackColor = true;
            this.BTN_Accepter.Click += new System.EventHandler(this.BTN_Accepter_Click);
            // 
            // BTN_supprimer
            // 
            this.BTN_supprimer.Location = new System.Drawing.Point(9, 146);
            this.BTN_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_supprimer.Name = "BTN_supprimer";
            this.BTN_supprimer.Size = new System.Drawing.Size(75, 22);
            this.BTN_supprimer.TabIndex = 13;
            this.BTN_supprimer.Text = "supprimer";
            this.BTN_supprimer.UseVisualStyleBackColor = true;
            this.BTN_supprimer.Click += new System.EventHandler(this.BTN_supprimer_Click);
            // 
            // JoueurManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 212);
            this.Controls.Add(this.BTN_supprimer);
            this.Controls.Add(this.BTN_Accepter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLB_joueurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX_Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Prenom);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.LBL_Joueur);
            this.Controls.Add(this.TBX_Alias);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JoueurManager";
            this.Text = "JoueurManager";
            this.Load += new System.EventHandler(this.JoueurManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Alias;
        private System.Windows.Forms.Label LBL_Joueur;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.TextBox TBX_Prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.CheckedListBox CLB_joueurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Accepter;
        private System.Windows.Forms.Button BTN_supprimer;
    }
}