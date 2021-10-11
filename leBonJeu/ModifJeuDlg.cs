using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leBonJeu
{
    public partial class ModifJeuDlg : Form
    {
        private LesJeux lstJeu;
        public ModifJeuDlg()
        {
            InitializeComponent();
            initGrille();
            lstJeu = null;
        }

        public ModifJeuDlg(LesJeux lj)
        {
            InitializeComponent();
            lstJeu = lj;
            initGrille();
            remplirGrille();
        }

        private void grille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            grille.Rows.Add(lstJeu.Taille);
        }

        private void remplirGrille()
        {
            ComboBox cb = new ComboBox();
            cb.DataSource = Enum.GetNames(typeof(Genre));

            for(int i=0;i<lstJeu.Taille;i++)
            {
                Jeu j = lstJeu.getJeuAt(i);

                grille.Rows[i].Cells["Nom"].Value = j.Nom;
                grille.Rows[i].Cells["Description"].Value = j.Desc;
                grille.Rows[i].Cells["Plateforme"].Value = j.Plateforme;
              //  grille.Rows[i].Cells["genre"].Value = cb;
                grille.Rows[i].Cells["Editeur"].Value = j.Editeur;
                grille.Rows[i].Cells["Prix"].Value = j.Prix + "";
                grille.Rows[i].Cells["Date_Sortie"].Value = j.Date_Sortie.ToShortDateString();
                grille.Rows[i].Cells["Recondition"].Value = j.Recondition;
               // grille.Rows[i].Cells["image"].Value = j.Photo;

                if(j.GetType()== typeof(JeuRetro))
                {
                    grille.Rows[i].Cells["Retro"].Value = true;
                    grille.Rows[i].Cells["Notice"].Value = ((JeuRetro)j).Notice;
                }
            }
        }
    }
}
