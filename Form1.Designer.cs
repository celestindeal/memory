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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_distribuer = new System.Windows.Forms.Button();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.bp_retourne = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 189);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(534, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(173, 183);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pb_04);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(357, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 183);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pb_03);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(180, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 183);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pb_02);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pb_01);
            // 
            // button_distribuer
            // 
            this.button_distribuer.Location = new System.Drawing.Point(85, 322);
            this.button_distribuer.Name = "button_distribuer";
            this.button_distribuer.Size = new System.Drawing.Size(150, 39);
            this.button_distribuer.TabIndex = 2;
            this.button_distribuer.Text = "Distribuer";
            this.button_distribuer.UseVisualStyleBackColor = true;
            this.button_distribuer.Click += new System.EventHandler(this.btn_Distribuer);
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
            // bp_retourne
            // 
            this.bp_retourne.Location = new System.Drawing.Point(258, 322);
            this.bp_retourne.Name = "bp_retourne";
            this.bp_retourne.Size = new System.Drawing.Size(150, 39);
            this.bp_retourne.TabIndex = 3;
            this.bp_retourne.Text = "Retourner";
            this.bp_retourne.UseVisualStyleBackColor = true;
            this.bp_retourne.Click += new System.EventHandler(this.bp_retourne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bp_retourne);
            this.Controls.Add(this.button_distribuer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_distribuer;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
        private System.Windows.Forms.Button bp_retourne;
    }
}

