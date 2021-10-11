namespace leBonJeu
{
    partial class SaisieJeuDlg
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJeu = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.LPlateforme = new System.Windows.Forms.TextBox();
            this.LPrix = new System.Windows.Forms.TextBox();
            this.LDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LNom = new System.Windows.Forms.TextBox();
            this.LEditeur = new System.Windows.Forms.TextBox();
            this.Parcourir = new System.Windows.Forms.Button();
            this.BRecondition = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BPhoto = new System.Windows.Forms.PictureBox();
            this.BGenre = new System.Windows.Forms.ComboBox();
            this.Chemin = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabJeu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabJeu);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabJeu
            // 
            this.tabJeu.Controls.Add(this.tableLayoutPanel1);
            this.tabJeu.Location = new System.Drawing.Point(4, 25);
            this.tabJeu.Name = "tabJeu";
            this.tabJeu.Padding = new System.Windows.Forms.Padding(3);
            this.tabJeu.Size = new System.Drawing.Size(792, 421);
            this.tabJeu.TabIndex = 0;
            this.tabJeu.Text = "Jeu";
            this.tabJeu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Valider, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Annuler, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LPlateforme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LPrix, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.LNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LEditeur, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Parcourir, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BRecondition, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BPhoto, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.BGenre, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Chemin, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.date, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Valider
            // 
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.Location = new System.Drawing.Point(395, 348);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(190, 64);
            this.Valider.TabIndex = 24;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Annuler
            // 
            this.Annuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annuler.Location = new System.Drawing.Point(199, 348);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(190, 64);
            this.Annuler.TabIndex = 23;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            // 
            // LPlateforme
            // 
            this.LPlateforme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPlateforme.Location = new System.Drawing.Point(199, 161);
            this.LPlateforme.Name = "LPlateforme";
            this.LPlateforme.Size = new System.Drawing.Size(190, 22);
            this.LPlateforme.TabIndex = 12;
            // 
            // LPrix
            // 
            this.LPrix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPrix.Location = new System.Drawing.Point(592, 92);
            this.LPrix.Name = "LPrix";
            this.LPrix.Size = new System.Drawing.Size(190, 22);
            this.LPrix.TabIndex = 11;
            // 
            // LDesc
            // 
            this.LDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LDesc.Location = new System.Drawing.Point(199, 92);
            this.LDesc.Name = "LDesc";
            this.LDesc.Size = new System.Drawing.Size(190, 22);
            this.LDesc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plateforme :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editeur :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date de parution :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Photo :";
            // 
            // LNom
            // 
            this.LNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNom.Location = new System.Drawing.Point(199, 23);
            this.LNom.Name = "LNom";
            this.LNom.Size = new System.Drawing.Size(190, 22);
            this.LNom.TabIndex = 8;
            // 
            // LEditeur
            // 
            this.LEditeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LEditeur.Location = new System.Drawing.Point(199, 230);
            this.LEditeur.Name = "LEditeur";
            this.LEditeur.Size = new System.Drawing.Size(190, 22);
            this.LEditeur.TabIndex = 13;
            // 
            // Parcourir
            // 
            this.Parcourir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parcourir.Location = new System.Drawing.Point(591, 210);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Size = new System.Drawing.Size(192, 63);
            this.Parcourir.TabIndex = 15;
            this.Parcourir.Text = "Parcourir";
            this.Parcourir.UseVisualStyleBackColor = true;
            this.Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // BRecondition
            // 
            this.BRecondition.AutoSize = true;
            this.BRecondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BRecondition.Location = new System.Drawing.Point(199, 279);
            this.BRecondition.Name = "BRecondition";
            this.BRecondition.Size = new System.Drawing.Size(190, 63);
            this.BRecondition.TabIndex = 16;
            this.BRecondition.Text = "Jeu reconditionné";
            this.BRecondition.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BPhoto
            // 
            this.BPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BPhoto.Location = new System.Drawing.Point(591, 279);
            this.BPhoto.Name = "BPhoto";
            this.BPhoto.Size = new System.Drawing.Size(192, 63);
            this.BPhoto.TabIndex = 25;
            this.BPhoto.TabStop = false;
            // 
            // BGenre
            // 
            this.BGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BGenre.FormattingEnabled = true;
            this.BGenre.Location = new System.Drawing.Point(591, 22);
            this.BGenre.Name = "BGenre";
            this.BGenre.Size = new System.Drawing.Size(192, 24);
            this.BGenre.TabIndex = 26;
            // 
            // Chemin
            // 
            this.Chemin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Chemin.AutoSize = true;
            this.Chemin.Location = new System.Drawing.Point(395, 302);
            this.Chemin.Name = "Chemin";
            this.Chemin.Size = new System.Drawing.Size(190, 17);
            this.Chemin.TabIndex = 27;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Location = new System.Drawing.Point(591, 161);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(192, 22);
            this.date.TabIndex = 28;
            // 
            // SaisieJeuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SaisieJeuDlg";
            this.Text = "SaisieJeuDlg";
            this.tabControl1.ResumeLayout(false);
            this.tabJeu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabJeu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox LPlateforme;
        private System.Windows.Forms.TextBox LPrix;
        private System.Windows.Forms.TextBox LDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LNom;
        private System.Windows.Forms.TextBox LEditeur;
        private System.Windows.Forms.Button Parcourir;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.CheckBox BRecondition;
        private System.Windows.Forms.PictureBox BPhoto;
        private System.Windows.Forms.ComboBox BGenre;
        private System.Windows.Forms.Label Chemin;
        private System.Windows.Forms.DateTimePicker date;
    }
}