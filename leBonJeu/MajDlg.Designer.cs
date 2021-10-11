namespace LeBonJeu
{
    partial class MajDlg
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
            this.pan = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Fermer = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.grille = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.ColumnCount = 1;
            this.pan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pan.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.pan.Controls.Add(this.grille, 0, 0);
            this.pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Name = "pan";
            this.pan.RowCount = 2;
            this.pan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.pan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.pan.Size = new System.Drawing.Size(1181, 450);
            this.pan.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Fermer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Valider, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 382);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Fermer
            // 
            this.Fermer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fermer.Location = new System.Drawing.Point(296, 3);
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(287, 59);
            this.Fermer.TabIndex = 0;
            this.Fermer.Text = "Fermer";
            this.Fermer.UseVisualStyleBackColor = true;
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // Valider
            // 
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.Location = new System.Drawing.Point(589, 3);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(287, 59);
            this.Valider.TabIndex = 1;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // grille
            // 
            this.grille.AllowUserToAddRows = false;
            this.grille.AllowUserToDeleteRows = false;
            this.grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grille.Location = new System.Drawing.Point(3, 3);
            this.grille.Name = "grille";
            this.grille.RowHeadersVisible = false;
            this.grille.RowHeadersWidth = 51;
            this.grille.RowTemplate.Height = 40;
            this.grille.Size = new System.Drawing.Size(1175, 373);
            this.grille.TabIndex = 1;
            // 
            // MajDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 450);
            this.Controls.Add(this.pan);
            this.Name = "MajDlg";
            this.Text = "Modification des jeux";
            this.pan.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Fermer;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.DataGridView grille;
    }
}