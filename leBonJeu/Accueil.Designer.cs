namespace LeBonJeu
{
    partial class Accueil
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tous les contenus");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Accessoires");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Figurines");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Jeux");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Jeu retro");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Types", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Genres");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Croissant");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Decroissant");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Trier", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            this.tableau = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.Filtre = new System.Windows.Forms.Label();
            this.arbre = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.boxGenre = new System.Windows.Forms.ComboBox();
            this.boxType = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.info = new System.Windows.Forms.RichTextBox();
            this.BPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bRetirer = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.listePhoto = new System.Windows.Forms.ListBox();
            this.tab = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesJeuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulle = new System.Windows.Forms.ToolTip(this.components);
            this.tableau.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPhoto)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableau
            // 
            this.tableau.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableau.ColumnCount = 3;
            this.tableau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.95249F));
            this.tableau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.04751F));
            this.tableau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableau.Controls.Add(this.label3, 2, 0);
            this.tableau.Controls.Add(this.titre, 1, 0);
            this.tableau.Controls.Add(this.Filtre, 0, 0);
            this.tableau.Controls.Add(this.arbre, 0, 1);
            this.tableau.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableau.Controls.Add(this.splitContainer1, 1, 2);
            this.tableau.Controls.Add(this.tableLayoutPanel3, 2, 2);
            this.tableau.Controls.Add(this.listePhoto, 2, 1);
            this.tableau.Controls.Add(this.tab, 1, 1);
            this.tableau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableau.Location = new System.Drawing.Point(0, 28);
            this.tableau.Name = "tableau";
            this.tableau.RowCount = 3;
            this.tableau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.60905F));
            this.tableau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.39095F));
            this.tableau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableau.Size = new System.Drawing.Size(1154, 599);
            this.tableau.TabIndex = 0;
            this.tableau.Tag = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(924, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Panier";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titre
            // 
            this.titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titre.Location = new System.Drawing.Point(186, 20);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(732, 25);
            this.titre.TabIndex = 1;
            this.titre.Text = "Mon titre";
            this.titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Filtre
            // 
            this.Filtre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtre.AutoSize = true;
            this.Filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filtre.Location = new System.Drawing.Point(3, 20);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(177, 25);
            this.Filtre.TabIndex = 0;
            this.Filtre.Text = "Filtre";
            this.Filtre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arbre
            // 
            this.arbre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.arbre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arbre.Location = new System.Drawing.Point(3, 69);
            this.arbre.Name = "arbre";
            treeNode1.Name = "tous";
            treeNode1.Text = "Tous les contenus";
            treeNode2.Name = "accessoireNoeud";
            treeNode2.Text = "Accessoires";
            treeNode3.Name = "figurineNoeud";
            treeNode3.Text = "Figurines";
            treeNode4.Name = "jeuNoeud";
            treeNode4.Text = "Jeux";
            treeNode5.Name = "retroNoeud";
            treeNode5.Text = "Jeu retro";
            treeNode6.Name = "typenoeud";
            treeNode6.Text = "Types";
            treeNode7.Name = "genreNoeud";
            treeNode7.Text = "Genres";
            treeNode8.Name = "croissant";
            treeNode8.Text = "Croissant";
            treeNode9.Name = "decroissant";
            treeNode9.Text = "Decroissant";
            treeNode10.Name = "trieNoeud";
            treeNode10.Text = "Trier";
            treeNode10.ToolTipText = "Trier";
            this.arbre.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode7,
            treeNode10});
            this.arbre.Size = new System.Drawing.Size(177, 380);
            this.arbre.TabIndex = 3;
            this.arbre.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.arbre_AfterSelect);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.boxGenre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.boxType, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 455);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(177, 141);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // boxGenre
            // 
            this.boxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxGenre.FormattingEnabled = true;
            this.boxGenre.Location = new System.Drawing.Point(3, 73);
            this.boxGenre.Name = "boxGenre";
            this.boxGenre.Size = new System.Drawing.Size(171, 24);
            this.boxGenre.TabIndex = 1;
            this.boxGenre.Text = "Selectionnez le genre";
            this.boxGenre.SelectedIndexChanged += new System.EventHandler(this.boxGenre_SelectedIndexChanged);
            // 
            // boxType
            // 
            this.boxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boxType.FormattingEnabled = true;
            this.boxType.Items.AddRange(new object[] {
            "Accessoires",
            "Figurines",
            "Jeux",
            "Jeu Retro"});
            this.boxType.Location = new System.Drawing.Point(3, 22);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(171, 24);
            this.boxType.TabIndex = 0;
            this.boxType.Text = "Selectionnez le type";
            this.boxType.SelectedIndexChanged += new System.EventHandler(this.boxType_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(186, 455);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.info);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BPhoto);
            this.splitContainer1.Size = new System.Drawing.Size(732, 141);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 5;
            // 
            // info
            // 
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(358, 141);
            this.info.TabIndex = 0;
            this.info.Text = "";
            // 
            // BPhoto
            // 
            this.BPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BPhoto.Location = new System.Drawing.Point(0, 0);
            this.BPhoto.Name = "BPhoto";
            this.BPhoto.Size = new System.Drawing.Size(370, 141);
            this.BPhoto.TabIndex = 0;
            this.BPhoto.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.bRetirer, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.bAjouter, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(924, 455);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(227, 141);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // bRetirer
            // 
            this.bRetirer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bRetirer.Location = new System.Drawing.Point(3, 86);
            this.bRetirer.Name = "bRetirer";
            this.bRetirer.Size = new System.Drawing.Size(221, 38);
            this.bRetirer.TabIndex = 1;
            this.bRetirer.Text = "Retirer du panier";
            this.bRetirer.UseVisualStyleBackColor = true;
            this.bRetirer.Click += new System.EventHandler(this.bRetirer_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bAjouter.Location = new System.Drawing.Point(3, 15);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(221, 40);
            this.bAjouter.TabIndex = 0;
            this.bAjouter.Text = "Ajouter au panier";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // listePhoto
            // 
            this.listePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listePhoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listePhoto.ColumnWidth = 5;
            this.listePhoto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listePhoto.FormattingEnabled = true;
            this.listePhoto.ItemHeight = 16;
            this.listePhoto.Location = new System.Drawing.Point(941, 69);
            this.listePhoto.Name = "listePhoto";
            this.listePhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listePhoto.Size = new System.Drawing.Size(210, 368);
            this.listePhoto.TabIndex = 7;
            this.listePhoto.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listePhoto_DrawItem);
            this.listePhoto.SelectedIndexChanged += new System.EventHandler(this.listePhoto_SelectedIndexChanged);
            // 
            // tab
            // 
            this.tab.AutoScroll = true;
            this.tab.BackColor = System.Drawing.SystemColors.Desktop;
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(186, 69);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(732, 380);
            this.tab.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem,
            this.visualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gererToolStripMenuItem
            // 
            this.gererToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.gererToolStripMenuItem.Name = "gererToolStripMenuItem";
            this.gererToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.gererToolStripMenuItem.Text = "Gerer";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.supprimerToolStripMenuItem.Text = "Modifier";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesJeuxToolStripMenuItem});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            // 
            // lesJeuxToolStripMenuItem
            // 
            this.lesJeuxToolStripMenuItem.Name = "lesJeuxToolStripMenuItem";
            this.lesJeuxToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.lesJeuxToolStripMenuItem.Text = "Les Jeux";
            this.lesJeuxToolStripMenuItem.Click += new System.EventHandler(this.lesJeuxToolStripMenuItem_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 627);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Resize += new System.EventHandler(this.Accueil_Resize);
            this.tableau.ResumeLayout(false);
            this.tableau.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BPhoto)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label Filtre;
        private System.Windows.Forms.TreeView arbre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox boxGenre;
        private System.Windows.Forms.ComboBox boxType;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.PictureBox BPhoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bRetirer;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.FlowLayoutPanel tab;
        private System.Windows.Forms.ListBox listePhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesJeuxToolStripMenuItem;
        private System.Windows.Forms.PictureBox last;
        private System.Windows.Forms.ToolTip bulle;
    }
}

