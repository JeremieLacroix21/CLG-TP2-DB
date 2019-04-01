namespace Custom_Controls
{
    partial class ItemListeJoueur
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
            this.BTN_Points = new System.Windows.Forms.Button();
            this.LAB_Num = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LAB_Alias = new System.Windows.Forms.Label();
            this.LAB_Points = new System.Windows.Forms.Label();
            this.BTN_Stats = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Points
            // 
            this.BTN_Points.Location = new System.Drawing.Point(6, 24);
            this.BTN_Points.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Points.Name = "BTN_Points";
            this.BTN_Points.Size = new System.Drawing.Size(111, 26);
            this.BTN_Points.TabIndex = 1;
            this.BTN_Points.Text = "Afficher Points";
            this.BTN_Points.UseVisualStyleBackColor = true;
            this.BTN_Points.Click += new System.EventHandler(this.BTN_Points_Click);
            // 
            // LAB_Num
            // 
            this.LAB_Num.AutoSize = true;
            this.LAB_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Num.Location = new System.Drawing.Point(9, 6);
            this.LAB_Num.Name = "LAB_Num";
            this.LAB_Num.Size = new System.Drawing.Size(22, 18);
            this.LAB_Num.TabIndex = 2;
            this.LAB_Num.Text = "#.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LAB_Num);
            this.flowLayoutPanel1.Controls.Add(this.LAB_Alias);
            this.flowLayoutPanel1.Controls.Add(this.LAB_Points);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Points);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Stats);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 57);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // LAB_Alias
            // 
            this.LAB_Alias.AutoSize = true;
            this.LAB_Alias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Alias.Location = new System.Drawing.Point(37, 6);
            this.LAB_Alias.Name = "LAB_Alias";
            this.LAB_Alias.Size = new System.Drawing.Size(124, 18);
            this.LAB_Alias.TabIndex = 0;
            this.LAB_Alias.Text = "Alias du Joueur";
            // 
            // LAB_Points
            // 
            this.LAB_Points.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.LAB_Points, true);
            this.LAB_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Points.Location = new System.Drawing.Point(167, 6);
            this.LAB_Points.Name = "LAB_Points";
            this.LAB_Points.Size = new System.Drawing.Size(62, 18);
            this.LAB_Points.TabIndex = 4;
            this.LAB_Points.Text = "(0 / 20)";
            // 
            // BTN_Stats
            // 
            this.BTN_Stats.Location = new System.Drawing.Point(117, 24);
            this.BTN_Stats.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Stats.Name = "BTN_Stats";
            this.BTN_Stats.Size = new System.Drawing.Size(111, 26);
            this.BTN_Stats.TabIndex = 3;
            this.BTN_Stats.Text = "Afficher Stats";
            this.BTN_Stats.UseVisualStyleBackColor = true;
            this.BTN_Stats.Click += new System.EventHandler(this.BTN_Stats_Click);
            // 
            // ItemListeJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemListeJoueur";
            this.Size = new System.Drawing.Size(246, 57);
            this.Load += new System.EventHandler(this.ItemListeJoueur_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_Points;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LAB_Num;
        private System.Windows.Forms.Label LAB_Alias;
        private System.Windows.Forms.Label LAB_Points;
        private System.Windows.Forms.Button BTN_Stats;
    }
}
