namespace LeBonJeu
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.saisieJeu = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Parcourir = new System.Windows.Forms.Button();
            this.Plateforme = new System.Windows.Forms.TextBox();
            this.Prix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Editeur = new System.Windows.Forms.TextBox();
            this.boxGenre = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Recondition = new System.Windows.Forms.CheckBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.Chemin = new System.Windows.Forms.Button();
            this.BPhoto = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.saisieJeuRetro = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Parcourir2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.REtat = new System.Windows.Forms.TextBox();
            this.Parcourir1 = new System.Windows.Forms.Button();
            this.RPlateforme = new System.Windows.Forms.TextBox();
            this.RPrix = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RNom = new System.Windows.Forms.TextBox();
            this.REditeur = new System.Windows.Forms.TextBox();
            this.boxGenre2 = new System.Windows.Forms.ComboBox();
            this.Rdate = new System.Windows.Forms.DateTimePicker();
            this.Etat = new System.Windows.Forms.Label();
            this.RDescription = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BRecond = new System.Windows.Forms.CheckBox();
            this.Notice = new System.Windows.Forms.CheckBox();
            this.Photo1 = new System.Windows.Forms.PictureBox();
            this.Photo2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Valider2 = new System.Windows.Forms.Button();
            this.tabcontrol.SuspendLayout();
            this.saisieJeu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPhoto)).BeginInit();
            this.saisieJeuRetro.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.saisieJeu);
            this.tabcontrol.Controls.Add(this.saisieJeuRetro);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1017, 599);
            this.tabcontrol.TabIndex = 0;
            // 
            // saisieJeu
            // 
            this.saisieJeu.Controls.Add(this.tableLayoutPanel1);
            this.saisieJeu.Location = new System.Drawing.Point(4, 25);
            this.saisieJeu.Name = "saisieJeu";
            this.saisieJeu.Padding = new System.Windows.Forms.Padding(3);
            this.saisieJeu.Size = new System.Drawing.Size(1009, 570);
            this.saisieJeu.TabIndex = 0;
            this.saisieJeu.Text = "Jeu";
            this.saisieJeu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Parcourir, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Plateforme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Prix, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Nom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Editeur, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.boxGenre, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.date, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Recondition, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Annuler, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Valider, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Chemin, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BPhoto, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Description, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Parcourir
            // 
            this.Parcourir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parcourir.Location = new System.Drawing.Point(753, 282);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Size = new System.Drawing.Size(247, 87);
            this.Parcourir.TabIndex = 19;
            this.Parcourir.Text = "Parcourir";
            this.Parcourir.UseVisualStyleBackColor = true;
            this.Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // Plateforme
            // 
            this.Plateforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Plateforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plateforme.Location = new System.Drawing.Point(253, 219);
            this.Plateforme.Name = "Plateforme";
            this.Plateforme.Size = new System.Drawing.Size(244, 27);
            this.Plateforme.TabIndex = 12;
            // 
            // Prix
            // 
            this.Prix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prix.Location = new System.Drawing.Point(753, 126);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(247, 27);
            this.Prix.TabIndex = 11;
            this.Prix.Text = "0.0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plateforme :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editeur :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date de parution :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Photo :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nom
            // 
            this.Nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(253, 33);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(244, 27);
            this.Nom.TabIndex = 8;
            // 
            // Editeur
            // 
            this.Editeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Editeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeur.Location = new System.Drawing.Point(253, 312);
            this.Editeur.Name = "Editeur";
            this.Editeur.Size = new System.Drawing.Size(244, 27);
            this.Editeur.TabIndex = 13;
            // 
            // boxGenre
            // 
            this.boxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boxGenre.FormattingEnabled = true;
            this.boxGenre.Location = new System.Drawing.Point(753, 34);
            this.boxGenre.Name = "boxGenre";
            this.boxGenre.Size = new System.Drawing.Size(247, 24);
            this.boxGenre.TabIndex = 14;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Location = new System.Drawing.Point(753, 221);
            this.date.Name = "date";
            this.date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date.Size = new System.Drawing.Size(247, 22);
            this.date.TabIndex = 15;
            // 
            // Recondition
            // 
            this.Recondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Recondition.AutoSize = true;
            this.Recondition.Location = new System.Drawing.Point(253, 408);
            this.Recondition.Name = "Recondition";
            this.Recondition.Size = new System.Drawing.Size(244, 21);
            this.Recondition.TabIndex = 16;
            this.Recondition.Text = "jeu reconditionné";
            this.Recondition.UseVisualStyleBackColor = true;
            // 
            // Annuler
            // 
            this.Annuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(253, 468);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(244, 93);
            this.Annuler.TabIndex = 18;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.Location = new System.Drawing.Point(503, 468);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(244, 93);
            this.Valider.TabIndex = 20;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Chemin
            // 
            this.Chemin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chemin.Location = new System.Drawing.Point(503, 375);
            this.Chemin.Name = "Chemin";
            this.Chemin.Size = new System.Drawing.Size(244, 87);
            this.Chemin.TabIndex = 21;
            this.Chemin.UseVisualStyleBackColor = true;
            // 
            // BPhoto
            // 
            this.BPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BPhoto.Location = new System.Drawing.Point(753, 375);
            this.BPhoto.Name = "BPhoto";
            this.BPhoto.Size = new System.Drawing.Size(247, 87);
            this.BPhoto.TabIndex = 22;
            this.BPhoto.TabStop = false;
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(253, 96);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(244, 87);
            this.Description.TabIndex = 23;
            this.Description.Text = "";
            // 
            // saisieJeuRetro
            // 
            this.saisieJeuRetro.Controls.Add(this.tableLayoutPanel2);
            this.saisieJeuRetro.Location = new System.Drawing.Point(4, 25);
            this.saisieJeuRetro.Name = "saisieJeuRetro";
            this.saisieJeuRetro.Padding = new System.Windows.Forms.Padding(3);
            this.saisieJeuRetro.Size = new System.Drawing.Size(1009, 570);
            this.saisieJeuRetro.TabIndex = 1;
            this.saisieJeuRetro.Text = "Jeu Retro";
            this.saisieJeuRetro.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Parcourir2, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label17, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.REtat, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.Parcourir1, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.RPlateforme, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.RPrix, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.RNom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.REditeur, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.boxGenre2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Rdate, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.Etat, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.RDescription, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.splitContainer1, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.Photo1, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.Photo2, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.Valider2, 2, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1003, 564);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Parcourir2
            // 
            this.Parcourir2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parcourir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parcourir2.Location = new System.Drawing.Point(753, 323);
            this.Parcourir2.Name = "Parcourir2";
            this.Parcourir2.Size = new System.Drawing.Size(247, 74);
            this.Parcourir2.TabIndex = 27;
            this.Parcourir2.Text = "Parcourir";
            this.Parcourir2.UseVisualStyleBackColor = true;
            this.Parcourir2.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(503, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(244, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Photo n°2 :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // REtat
            // 
            this.REtat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.REtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REtat.Location = new System.Drawing.Point(253, 346);
            this.REtat.Name = "REtat";
            this.REtat.Size = new System.Drawing.Size(244, 27);
            this.REtat.TabIndex = 24;
            // 
            // Parcourir1
            // 
            this.Parcourir1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parcourir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parcourir1.Location = new System.Drawing.Point(753, 243);
            this.Parcourir1.Name = "Parcourir1";
            this.Parcourir1.Size = new System.Drawing.Size(247, 74);
            this.Parcourir1.TabIndex = 19;
            this.Parcourir1.Text = "Parcourir";
            this.Parcourir1.UseVisualStyleBackColor = true;
            this.Parcourir1.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // RPlateforme
            // 
            this.RPlateforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RPlateforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPlateforme.Location = new System.Drawing.Point(253, 186);
            this.RPlateforme.Name = "RPlateforme";
            this.RPlateforme.Size = new System.Drawing.Size(244, 27);
            this.RPlateforme.TabIndex = 12;
            // 
            // RPrix
            // 
            this.RPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPrix.Location = new System.Drawing.Point(753, 106);
            this.RPrix.Name = "RPrix";
            this.RPrix.Size = new System.Drawing.Size(247, 27);
            this.RPrix.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nom :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Description :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Plateforme :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Editeur :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(503, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Genre :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(503, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Prix :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(503, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Date de parution :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(503, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Photo n°1 :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RNom
            // 
            this.RNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNom.Location = new System.Drawing.Point(253, 26);
            this.RNom.Name = "RNom";
            this.RNom.Size = new System.Drawing.Size(244, 27);
            this.RNom.TabIndex = 8;
            // 
            // REditeur
            // 
            this.REditeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.REditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REditeur.Location = new System.Drawing.Point(253, 266);
            this.REditeur.Name = "REditeur";
            this.REditeur.Size = new System.Drawing.Size(244, 27);
            this.REditeur.TabIndex = 13;
            // 
            // boxGenre2
            // 
            this.boxGenre2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boxGenre2.FormattingEnabled = true;
            this.boxGenre2.Location = new System.Drawing.Point(753, 28);
            this.boxGenre2.Name = "boxGenre2";
            this.boxGenre2.Size = new System.Drawing.Size(247, 24);
            this.boxGenre2.TabIndex = 14;
            // 
            // Rdate
            // 
            this.Rdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdate.Location = new System.Drawing.Point(753, 189);
            this.Rdate.Name = "Rdate";
            this.Rdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdate.Size = new System.Drawing.Size(247, 22);
            this.Rdate.TabIndex = 15;
            // 
            // Etat
            // 
            this.Etat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Etat.AutoSize = true;
            this.Etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etat.Location = new System.Drawing.Point(3, 350);
            this.Etat.Name = "Etat";
            this.Etat.Size = new System.Drawing.Size(244, 20);
            this.Etat.TabIndex = 21;
            this.Etat.Text = "Etat :";
            this.Etat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RDescription
            // 
            this.RDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RDescription.Location = new System.Drawing.Point(253, 83);
            this.RDescription.Name = "RDescription";
            this.RDescription.Size = new System.Drawing.Size(244, 74);
            this.RDescription.TabIndex = 23;
            this.RDescription.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(253, 403);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BRecond);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Notice);
            this.splitContainer1.Size = new System.Drawing.Size(244, 74);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 25;
            // 
            // BRecond
            // 
            this.BRecond.AutoSize = true;
            this.BRecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BRecond.Location = new System.Drawing.Point(0, 0);
            this.BRecond.Name = "BRecond";
            this.BRecond.Size = new System.Drawing.Size(244, 34);
            this.BRecond.TabIndex = 0;
            this.BRecond.Text = "Jeu reconditionné";
            this.BRecond.UseVisualStyleBackColor = true;
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notice.Location = new System.Drawing.Point(0, 0);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(244, 36);
            this.Notice.TabIndex = 0;
            this.Notice.Text = "Avec notice";
            this.Notice.UseVisualStyleBackColor = true;
            // 
            // Photo1
            // 
            this.Photo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo1.Location = new System.Drawing.Point(503, 403);
            this.Photo1.Name = "Photo1";
            this.Photo1.Size = new System.Drawing.Size(244, 74);
            this.Photo1.TabIndex = 28;
            this.Photo1.TabStop = false;
            // 
            // Photo2
            // 
            this.Photo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo2.Location = new System.Drawing.Point(753, 403);
            this.Photo2.Name = "Photo2";
            this.Photo2.Size = new System.Drawing.Size(247, 74);
            this.Photo2.TabIndex = 29;
            this.Photo2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(253, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 78);
            this.button1.TabIndex = 30;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider2
            // 
            this.Valider2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider2.Location = new System.Drawing.Point(503, 483);
            this.Valider2.Name = "Valider2";
            this.Valider2.Size = new System.Drawing.Size(244, 78);
            this.Valider2.TabIndex = 31;
            this.Valider2.Text = "Valider";
            this.Valider2.UseVisualStyleBackColor = true;
            this.Valider2.Click += new System.EventHandler(this.Valider2_Click);
            // 
            // SaisieJeuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 599);
            this.Controls.Add(this.tabcontrol);
            this.Name = "SaisieJeuDlg";
            this.Text = "SaisieJeuDlg";
            this.tabcontrol.ResumeLayout(false);
            this.saisieJeu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPhoto)).EndInit();
            this.saisieJeuRetro.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Photo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage saisieJeu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Plateforme;
        private System.Windows.Forms.TextBox Prix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Editeur;
        private System.Windows.Forms.ComboBox boxGenre;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TabPage saisieJeuRetro;
        private System.Windows.Forms.Button Parcourir;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Parcourir1;
        private System.Windows.Forms.TextBox RPlateforme;
        private System.Windows.Forms.TextBox RPrix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RNom;
        private System.Windows.Forms.TextBox REditeur;
        private System.Windows.Forms.ComboBox boxGenre2;
        private System.Windows.Forms.DateTimePicker Rdate;
        private System.Windows.Forms.CheckBox Recondition;
        private System.Windows.Forms.Button Chemin;
        private System.Windows.Forms.PictureBox BPhoto;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label Etat;
        private System.Windows.Forms.RichTextBox RDescription;
        private System.Windows.Forms.TextBox REtat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox BRecond;
        private System.Windows.Forms.CheckBox Notice;
        private System.Windows.Forms.Button Parcourir2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox Photo1;
        private System.Windows.Forms.PictureBox Photo2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Valider2;
    }
}