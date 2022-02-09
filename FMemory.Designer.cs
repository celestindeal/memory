namespace meory
{
    partial class FMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMemory));
            this.tlpTapisDeCartes = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_01 = new System.Windows.Forms.PictureBox();
            this.pb_02 = new System.Windows.Forms.PictureBox();
            this.pb_03 = new System.Windows.Forms.PictureBox();
            this.pb_04 = new System.Windows.Forms.PictureBox();
            this.btn_Distributeur = new System.Windows.Forms.Button();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.tlpTapisDeCartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTapisDeCartes
            // 
            this.tlpTapisDeCartes.ColumnCount = 4;
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.Controls.Add(this.pb_04, 3, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_03, 2, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_02, 1, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_01, 0, 0);
            this.tlpTapisDeCartes.Location = new System.Drawing.Point(31, 91);
            this.tlpTapisDeCartes.Name = "tlpTapisDeCartes";
            this.tlpTapisDeCartes.RowCount = 1;
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTapisDeCartes.Size = new System.Drawing.Size(440, 110);
            this.tlpTapisDeCartes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Le grand jeu du Memory !";
            // 
            // pb_01
            // 
            this.pb_01.Location = new System.Drawing.Point(3, 3);
            this.pb_01.Name = "pb_01";
            this.pb_01.Size = new System.Drawing.Size(100, 100);
            this.pb_01.TabIndex = 0;
            this.pb_01.TabStop = false;
            // 
            // pb_02
            // 
            this.pb_02.Location = new System.Drawing.Point(113, 3);
            this.pb_02.Name = "pb_02";
            this.pb_02.Size = new System.Drawing.Size(100, 100);
            this.pb_02.TabIndex = 1;
            this.pb_02.TabStop = false;
            // 
            // pb_03
            // 
            this.pb_03.Location = new System.Drawing.Point(223, 3);
            this.pb_03.Name = "pb_03";
            this.pb_03.Size = new System.Drawing.Size(100, 100);
            this.pb_03.TabIndex = 2;
            this.pb_03.TabStop = false;
            // 
            // pb_04
            // 
            this.pb_04.Location = new System.Drawing.Point(333, 3);
            this.pb_04.Name = "pb_04";
            this.pb_04.Size = new System.Drawing.Size(100, 100);
            this.pb_04.TabIndex = 3;
            this.pb_04.TabStop = false;
            this.pb_04.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_Distributeur
            // 
            this.btn_Distributeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Distributeur.Location = new System.Drawing.Point(34, 231);
            this.btn_Distributeur.Name = "btn_Distributeur";
            this.btn_Distributeur.Size = new System.Drawing.Size(112, 39);
            this.btn_Distributeur.TabIndex = 2;
            this.btn_Distributeur.Text = "DISTRIBUER";
            this.btn_Distributeur.UseVisualStyleBackColor = true;
            this.btn_Distributeur.Click += new System.EventHandler(this.btn_Distributeur_Click);
            // 
            // ilSabotDeCartes
            // 
            this.ilSabotDeCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSabotDeCartes.ImageStream")));
            this.ilSabotDeCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSabotDeCartes.Images.SetKeyName(0, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(1, "Dialogue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(2, "Diplome.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(3, "FemmeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(4, "FemmeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(5, "FemmeBlanche.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(6, "FemmeBleue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(7, "FemmeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(8, "FemmeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(9, "FemmeInformaticienBrune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(10, "FemmeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(11, "FemmeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(12, "FemmeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(13, "FemmeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(14, "FemmeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(15, "FemmePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(16, "FemmePoliciere.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(17, "HommeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(18, "HommeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(19, "HommeBleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(20, "HommeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(21, "HommeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(22, "HommeGarde.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(23, "HommeInformaticienBrun.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(24, "HommeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(25, "HommeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(26, "HommeMarron.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(27, "HommeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(28, "HommeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(29, "HommeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(30, "HommePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(31, "HommePolicier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(32, "Joker.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(33, "LivreurPizza.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(34, "MarinMousse.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(35, "MarinOfficier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(36, "MarinPompon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(37, "Mecanicien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(38, "Pilote.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(39, "Pompier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(40, "Serveur.jpg");
            // 
            // FMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 584);
            this.Controls.Add(this.btn_Distributeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlpTapisDeCartes);
            this.Name = "FMemory";
            this.Text = "Form1";
            this.tlpTapisDeCartes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTapisDeCartes;
        private System.Windows.Forms.PictureBox pb_04;
        private System.Windows.Forms.PictureBox pb_03;
        private System.Windows.Forms.PictureBox pb_02;
        private System.Windows.Forms.PictureBox pb_01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Distributeur;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
    }
}

