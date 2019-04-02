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
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.TBX_Prénom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_Lastname = new System.Windows.Forms.TextBox();
            this.CLB_joueurs = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Accepter = new System.Windows.Forms.Button();
            this.BTN_supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(12, 29);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(100, 22);
            this.TBX_Nom.TabIndex = 0;
            this.TBX_Nom.TextChanged += new System.EventHandler(this.TBX_Nom_TextChanged);
            // 
            // LBL_Joueur
            // 
            this.LBL_Joueur.AutoSize = true;
            this.LBL_Joueur.Location = new System.Drawing.Point(9, 9);
            this.LBL_Joueur.Name = "LBL_Joueur";
            this.LBL_Joueur.Size = new System.Drawing.Size(46, 17);
            this.LBL_Joueur.TabIndex = 1;
            this.LBL_Joueur.Text = "Alias :";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Location = new System.Drawing.Point(12, 147);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(100, 27);
            this.BTN_Ajouter.TabIndex = 3;
            this.BTN_Ajouter.Text = "Ajouter joueur";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // TBX_Prénom
            // 
            this.TBX_Prénom.Location = new System.Drawing.Point(12, 74);
            this.TBX_Prénom.Name = "TBX_Prénom";
            this.TBX_Prénom.Size = new System.Drawing.Size(100, 22);
            this.TBX_Prénom.TabIndex = 5;
            this.TBX_Prénom.TextChanged += new System.EventHandler(this.TBX_Prénom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prénom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom de famille:";
            // 
            // TBX_Lastname
            // 
            this.TBX_Lastname.Location = new System.Drawing.Point(12, 119);
            this.TBX_Lastname.Name = "TBX_Lastname";
            this.TBX_Lastname.Size = new System.Drawing.Size(100, 22);
            this.TBX_Lastname.TabIndex = 7;
            this.TBX_Lastname.TextChanged += new System.EventHandler(this.TBX_Lastname_TextChanged);
            // 
            // CLB_joueurs
            // 
            this.CLB_joueurs.FormattingEnabled = true;
            this.CLB_joueurs.Location = new System.Drawing.Point(136, 30);
            this.CLB_joueurs.Name = "CLB_joueurs";
            this.CLB_joueurs.Size = new System.Drawing.Size(232, 191);
            this.CLB_joueurs.TabIndex = 9;
            this.CLB_joueurs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_joueurs_ItemCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sélectionner 2-4 joueurs:";
            // 
            // BTN_Accepter
            // 
            this.BTN_Accepter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Accepter.Location = new System.Drawing.Point(268, 227);
            this.BTN_Accepter.Name = "BTN_Accepter";
            this.BTN_Accepter.Size = new System.Drawing.Size(100, 27);
            this.BTN_Accepter.TabIndex = 11;
            this.BTN_Accepter.Text = "Accepter";
            this.BTN_Accepter.UseVisualStyleBackColor = true;
            this.BTN_Accepter.Click += new System.EventHandler(this.BTN_Accepter_Click);
            // 
            // BTN_supprimer
            // 
            this.BTN_supprimer.Location = new System.Drawing.Point(12, 180);
            this.BTN_supprimer.Name = "BTN_supprimer";
            this.BTN_supprimer.Size = new System.Drawing.Size(100, 27);
            this.BTN_supprimer.TabIndex = 13;
            this.BTN_supprimer.Text = "supprimer";
            this.BTN_supprimer.UseVisualStyleBackColor = true;
            this.BTN_supprimer.Click += new System.EventHandler(this.BTN_supprimer_Click);
            // 
            // JoueurManager
            // 
            this.AcceptButton = this.BTN_Accepter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.BTN_supprimer);
            this.Controls.Add(this.BTN_Accepter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLB_joueurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX_Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Prénom);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.LBL_Joueur);
            this.Controls.Add(this.TBX_Nom);
            this.Name = "JoueurManager";
            this.Text = "JoueurManager";
            this.Load += new System.EventHandler(this.JoueurManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.Label LBL_Joueur;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.TextBox TBX_Prénom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_Lastname;
        private System.Windows.Forms.CheckedListBox CLB_joueurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Accepter;
        private System.Windows.Forms.Button BTN_supprimer;
    }
}