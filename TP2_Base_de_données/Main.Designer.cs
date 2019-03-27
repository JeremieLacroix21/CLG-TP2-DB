namespace TP2_Base_de_données
{
    partial class Main
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Touner = new System.Windows.Forms.Button();
            this.CBB1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(151, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catégorie";
            // 
            // Touner
            // 
            this.Touner.Location = new System.Drawing.Point(12, 12);
            this.Touner.Name = "Touner";
            this.Touner.Size = new System.Drawing.Size(116, 39);
            this.Touner.TabIndex = 1;
            this.Touner.Text = "Tourner";
            this.Touner.UseVisualStyleBackColor = true;
            this.Touner.Click += new System.EventHandler(this.Touner_Click);
            // 
            // CBB1
            // 
            this.CBB1.FormattingEnabled = true;
            this.CBB1.Location = new System.Drawing.Point(13, 67);
            this.CBB1.Name = "CBB1";
            this.CBB1.Size = new System.Drawing.Size(303, 24);
            this.CBB1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 139);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBB1);
            this.Controls.Add(this.Touner);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Trivia";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Touner;
        private System.Windows.Forms.ComboBox CBB1;
        private System.Windows.Forms.Button button1;
    }
}

