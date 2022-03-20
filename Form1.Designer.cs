namespace meory
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.pb_Recherche = new System.Windows.Forms.PictureBox();
            this.btn_Jouer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Recherche)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ilSabotDeCartes
            // 
            this.ilSabotDeCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSabotDeCartes.ImageStream")));
            this.ilSabotDeCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSabotDeCartes.Images.SetKeyName(0, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(1, "Abeille.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(2, "Autruches.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(3, "Canard.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(4, "Chameau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(5, "Chien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(6, "ChienGamelle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(7, "ChienMechant.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(8, "ChienSavant.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(9, "Chimpanze.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(10, "Coccinelle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(11, "Crabe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(12, "Crocodile.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(13, "Dauphin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(14, "Ecureuil.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(15, "Hanneton.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(16, "Hibou.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(17, "Hippocampe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(18, "Homard.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(19, "Kangourou.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(20, "Lapin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(21, "LapinChapeau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(22, "LapinRieur.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(23, "Lion.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(24, "MacareuxMoine.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(25, "Mouette.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(26, "Ocelot.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(27, "OiseauCage.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(28, "OiseauChante.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(29, "OiseauPic.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(30, "Orycterope.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(31, "Papillon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(32, "PoissonBocal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(33, "PoissonBulle.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(34, "PoissonPapillon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(35, "PorcEpic.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(36, "PorcEpic2.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(37, "Renne.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(38, "Renne2.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(39, "Serpent.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(40, "Taureau.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(41, "Vache.jpg");
            // 
            // pb_Recherche
            // 
            this.pb_Recherche.Location = new System.Drawing.Point(786, 131);
            this.pb_Recherche.Name = "pb_Recherche";
            this.pb_Recherche.Size = new System.Drawing.Size(290, 147);
            this.pb_Recherche.TabIndex = 4;
            this.pb_Recherche.TabStop = false;
            // 
            // btn_Jouer
            // 
            this.btn_Jouer.Location = new System.Drawing.Point(786, 304);
            this.btn_Jouer.Name = "btn_Jouer";
            this.btn_Jouer.Size = new System.Drawing.Size(290, 116);
            this.btn_Jouer.TabIndex = 5;
            this.btn_Jouer.Text = "Jouer";
            this.btn_Jouer.UseVisualStyleBackColor = true;
            this.btn_Jouer.Click += new System.EventHandler(this.btn_Jouer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 546);
            this.Controls.Add(this.btn_Jouer);
            this.Controls.Add(this.pb_Recherche);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Recherche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
        private System.Windows.Forms.PictureBox pb_Recherche;
        private System.Windows.Forms.Button btn_Jouer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

