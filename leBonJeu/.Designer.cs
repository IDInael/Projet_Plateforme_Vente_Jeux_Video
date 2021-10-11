using System.Windows.Forms;
using System.Drawing;
using System;

namespace leBonJeu
{
    partial class Fenetre
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listPhoto = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.edition = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTous = new System.Windows.Forms.Button();
            this.BRetro = new System.Windows.Forms.Button();
            this.LGenre = new System.Windows.Forms.Label();
            this.ListeGenre = new System.Windows.Forms.ComboBox();
            this.ListeJeu = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listPhoto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 420);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // listPhoto
            // 
            this.listPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPhoto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listPhoto.FormattingEnabled = true;
            this.listPhoto.ItemHeight = 16;
            this.listPhoto.Location = new System.Drawing.Point(0, 0);
            this.listPhoto.Name = "listPhoto";
            this.listPhoto.Size = new System.Drawing.Size(212, 420);
            this.listPhoto.TabIndex = 0;
            this.listPhoto.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listPhoto_DrawItem);
            this.listPhoto.SelectedIndexChanged += new System.EventHandler(this.listPhoto_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.edition);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(584, 420);
            this.splitContainer2.SplitterDistance = 348;
            this.splitContainer2.TabIndex = 0;
            // 
            // edition
            // 
            this.edition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edition.Location = new System.Drawing.Point(0, 0);
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(348, 420);
            this.edition.TabIndex = 0;
            this.edition.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTous, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BRetro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LGenre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListeGenre, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ListeJeu, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Photo, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTous
            // 
            this.BTous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTous.Location = new System.Drawing.Point(3, 3);
            this.BTous.Name = "BTous";
            this.BTous.Size = new System.Drawing.Size(226, 63);
            this.BTous.TabIndex = 0;
            this.BTous.Text = "Tous les jeux";
            this.BTous.UseVisualStyleBackColor = true;
            this.BTous.Click += new System.EventHandler(this.BTous_Click);
            // 
            // BRetro
            // 
            this.BRetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BRetro.Location = new System.Drawing.Point(3, 72);
            this.BRetro.Name = "BRetro";
            this.BRetro.Size = new System.Drawing.Size(226, 63);
            this.BRetro.TabIndex = 1;
            this.BRetro.Text = "Jeux retro";
            this.BRetro.UseVisualStyleBackColor = true;
            this.BRetro.Click += new System.EventHandler(this.BRetro_Click);
            // 
            // LGenre
            // 
            this.LGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LGenre.AutoSize = true;
            this.LGenre.Location = new System.Drawing.Point(3, 138);
            this.LGenre.Name = "LGenre";
            this.LGenre.Size = new System.Drawing.Size(226, 69);
            this.LGenre.TabIndex = 2;
            this.LGenre.Text = "Selectionner un genre !";
            this.LGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListeGenre
            // 
            this.ListeGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeGenre.FormattingEnabled = true;
            this.ListeGenre.Location = new System.Drawing.Point(3, 229);
            this.ListeGenre.Name = "ListeGenre";
            this.ListeGenre.Size = new System.Drawing.Size(226, 24);
            this.ListeGenre.TabIndex = 3;
            this.ListeGenre.SelectedIndexChanged += new System.EventHandler(this.ListeGenre_SelectedIndexChanged);
            // 
            // ListeJeu
            // 
            this.ListeJeu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeJeu.FormattingEnabled = true;
            this.ListeJeu.ItemHeight = 16;
            this.ListeJeu.Location = new System.Drawing.Point(3, 279);
            this.ListeJeu.Name = "ListeJeu";
            this.ListeJeu.Size = new System.Drawing.Size(226, 63);
            this.ListeJeu.TabIndex = 4;
            this.ListeJeu.SelectedIndexChanged += new System.EventHandler(this.ListeJeu_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.visualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.jeuToolStripMenuItem.Text = "Ajouter";
            this.jeuToolStripMenuItem.Click += new System.EventHandler(this.jeuToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem1});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            // 
            // jeuToolStripMenuItem1
            // 
            this.jeuToolStripMenuItem1.Name = "jeuToolStripMenuItem1";
            this.jeuToolStripMenuItem1.Size = new System.Drawing.Size(113, 26);
            this.jeuToolStripMenuItem1.Text = "Jeu";
            this.jeuToolStripMenuItem1.Click += new System.EventHandler(this.jeuToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // Photo
            // 
            this.Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo.Location = new System.Drawing.Point(3, 348);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(226, 69);
            this.Photo.TabIndex = 5;
            this.Photo.TabStop = false;
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fenetre";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listPhoto;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox edition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTous;
        private System.Windows.Forms.Button BRetro;
        private System.Windows.Forms.Label LGenre;
        private System.Windows.Forms.ComboBox ListeGenre;
        private System.Windows.Forms.ListBox ListeJeu;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem1;

        private void listPhoto_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int i = listPhoto.SelectedIndex;
            
            edition.Text = this.lstJeu.getJeuAt(i)+"";
        }

        private void listPhoto_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            ImageList listImg = new ImageList();
            this.listPhoto.ItemHeight = 100;
            listImg.ImageSize = new Size(200, 100);
            foreach(Jeu j in this.lstJeu.LstJeu)
            {
                listImg.Images.Add(j.Photo);
            }
            Point p = e.Bounds.Location;
            
            listImg.Draw(e.Graphics, p, e.Index);
        }

        private void jeuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaisieJeuDlg diag = new SaisieJeuDlg();
            diag.ShowDialog();
        }

        private ToolStripMenuItem modifierToolStripMenuItem;
    }
}

