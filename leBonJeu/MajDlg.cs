using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeBonJeu
{
    public partial class MajDlg : Form
    {
        private LesJeux lj;
        public MajDlg()
        {
            InitializeComponent();
            lj = new LesJeux();
            initGrille();
            
        }

        public MajDlg(LesJeux liste)
        {
            InitializeComponent();
            lj = liste;
            initGrille();
            remplirGrille();
        }

        public LesJeux Liste
        {
            get { return this.lj; }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Visible = false;
            this.Dispose();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void initGrille()
        {
            //colonne des noms
            DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            grille.Columns.Add(Nom);

            //colonne description
            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            grille.Columns.Add(Description);

            //colonne plateforme
            DataGridViewTextBoxColumn Plateforme = new DataGridViewTextBoxColumn();
            Plateforme.HeaderText = "Plateforme";
            Plateforme.Name = "Plateforme";
            Plateforme.ReadOnly = true;
            grille.Columns.Add(Plateforme);

            //genre
            DataGridViewComboBoxColumn genre = new DataGridViewComboBoxColumn();
            genre.ValueType = typeof(Genre);
            genre.DataSource = Enum.GetValues(typeof(Genre));
            genre.HeaderText = "Genre";
            genre.Name = "genre";
            genre.ReadOnly = false;
            grille.Columns.Add(genre);

            //editeur
            DataGridViewTextBoxColumn Editeur = new DataGridViewTextBoxColumn();
            Editeur.HeaderText = "Editeur";
            Editeur.Name = "Editeur";
            Editeur.ReadOnly = true;
            grille.Columns.Add(Editeur);

            //prix

            DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            Prix.ReadOnly = false;
            grille.Columns.Add(Prix);

            //date sortie

            DataGridViewTextBoxColumn Date_Sortie = new DataGridViewTextBoxColumn();
            Date_Sortie.HeaderText = "Date Sortie";
            Date_Sortie.Name = "Date_Sortie";
            Date_Sortie.ReadOnly = true;
            grille.Columns.Add(Date_Sortie);

            //recondition
            DataGridViewCheckBoxColumn Recondition = new DataGridViewCheckBoxColumn();
            Recondition.HeaderText = "Reconditionné";
            Recondition.Name = "Recondition";
            Recondition.ReadOnly = false;
            grille.Columns.Add(Recondition);

            //image
            DataGridViewImageColumn Photo = new DataGridViewImageColumn();
            Photo.HeaderText = "Image";
            Photo.Name = "Photo";
            Photo.ReadOnly = true;
            Photo.CellTemplate = new DataGridViewImageCell();
            grille.Columns.Add(Photo);

            //jeu retro
            DataGridViewCheckBoxColumn Retro = new DataGridViewCheckBoxColumn();
            Retro.HeaderText = "Jeu retro";
            Retro.Name = "Retro";
            Retro.ReadOnly = false;
            grille.Columns.Add(Retro);

            //etat
            DataGridViewTextBoxColumn Etat = new DataGridViewTextBoxColumn();
            Etat.HeaderText = "Etat";
            Etat.Name = "Etat";
            Etat.ReadOnly = false;
            grille.Columns.Add(Etat);

            //notice
            DataGridViewCheckBoxColumn Notice = new DataGridViewCheckBoxColumn();
            Notice.HeaderText = "Notice";
            Notice.Name = "Notice";
            Notice.ReadOnly = false;
            grille.Columns.Add(Notice);

            grille.Rows.Add(lj.Taille);

            //grille.DataSource = test;
            grille.CellEndEdit += new DataGridViewCellEventHandler(grille_CellEndEdit);
            grille.RowStateChanged += new DataGridViewRowStateChangedEventHandler(grille_RowStateChanged);
        }

        private void remplirGrille()
        {
            for (int i = 0; i < lj.Taille; i++)
            {
                Jeu j = lj.getJeuAt(i);

                grille.Rows[i].Cells["Nom"].Value = j.Nom;
                grille.Rows[i].Cells["Description"].Value = j.Desc;
                grille.Rows[i].Cells["Plateforme"].Value = j.Plateforme;
                grille.Rows[i].Cells["genre"].Value = (Genre)j.indexGenre;
                grille.Rows[i].Cells["Editeur"].Value = j.Editeur;
                grille.Rows[i].Cells["Prix"].Value = j.Prix + "";
                grille.Rows[i].Cells["Date_Sortie"].Value = j.Date_Sortie.ToShortDateString();
                grille.Rows[i].Cells["Recondition"].Value = j.Recondition;
                grille.Rows[i].Cells["Photo"].Value = j.Photo.GetThumbnailImage(40, 40, null, IntPtr.Zero) ;

                if (j.GetType() == typeof(JeuRetro))
                {
                    grille.Rows[i].Cells["Retro"].Value = true;
                    grille.Rows[i].Cells["Notice"].Value = ((JeuRetro)j).Notice;
                    grille.Rows[i].Cells["Etat"].Value = ((JeuRetro)j).Etat;
                }
            }
        }

        void grille_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            Jeu j = lj.getJeuAt(i);//prendre le jeu à l'indice à la ligne ou il y a le changement

            if (e.ColumnIndex == grille.Columns["genre"].Index)
            {
                grille.Rows[i].Cells["genre"].Value = (Genre)((int)grille.Rows[i].Cells[e.ColumnIndex].Value);
                j.GenreG =(Genre) grille.Rows[i].Cells["genre"].Value;
            }
            else
            {
                if (e.ColumnIndex == grille.Columns["Recondition"].Index)
                {
                    grille.Rows[i].Cells["Recondition"].Value = grille.Rows[i].Cells[e.ColumnIndex].Value;
                    j.Recondition = (bool)grille.Rows[i].Cells["Recondition"].Value;
                }
                else
                {
                    if (e.ColumnIndex == grille.Columns["Prix"].Index)
                    {
                        grille.Rows[i].Cells["Retro"].Value = grille.Rows[i].Cells[e.ColumnIndex].Value;
                        double pr = Double.Parse((string)grille.Rows[i].Cells["Retro"].Value);
                        j.Prix = pr;
                    }
                    else
                    {
                        if (e.ColumnIndex == grille.Columns["Retro"].Index)
                        {
                            grille.Rows[i].Cells["Retro"].Value = grille.Rows[i].Cells[e.ColumnIndex].Value;
                            JeuRetro jr = new JeuRetro(j, "", false);
                            lj.ajoutJeuAt(jr, i);
                        }
                        else
                        {
                            if (j.GetType() == typeof(JeuRetro))
                            {
                                if (e.ColumnIndex == grille.Columns["Notice"].Index)
                                {
                                    grille.Rows[i].Cells["Notice"].Value = grille.Rows[i].Cells[e.ColumnIndex].Value;
                                    ((JeuRetro)j).Notice = (bool)grille.Rows[i].Cells["Notice"].Value;
                                }
                                else
                                {
                                    if (e.ColumnIndex == grille.Columns["Etat"].Index)
                                    {
                                        grille.Rows[i].Cells["Etat"].Value = grille.Rows[i].Cells[e.ColumnIndex].Value;
                                        ((JeuRetro)j).Etat = (string)grille.Rows[i].Cells["Etat"].Value;
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }

        private void grille_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.DataBoundItem != null)
            {
                e.Row.Cells["genre"].Value = (Genre)((int)e.Row.Cells["genre"].Value);
            }
        }
    }
}
