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
    public partial class SaisieJeuDlg : Form
    {
        Jeu j;
        public SaisieJeuDlg()
        {
            InitializeComponent();
            boxGenre.DataSource = Enum.GetNames(typeof(Genre));
            boxGenre2.DataSource = Enum.GetNames(typeof(Genre));
            j = null;
        }

        public Jeu NewJeu
        {
            get { return this.j; }
        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            Image img = null;
            string nom = ((Button)sender).Name;

            if(diag.ShowDialog()==DialogResult.OK)
            {
                string s = diag.FileName;
                
                img = Image.FromFile(s);
                switch (nom)
                {
                    case "Parcourir":
                        Chemin.Text = s;
                        BPhoto.Image = img.GetThumbnailImage(BPhoto.Width, BPhoto.Height, null, IntPtr.Zero);
                        break;
                    case "Parcourir1":
                        Photo1.Image = img.GetThumbnailImage(Photo1.Width, Photo1.Height, null, IntPtr.Zero);
                        break;
                    case "Parcourir2":
                        Photo2.Image = img.GetThumbnailImage(Photo2.Width, Photo2.Height, null, IntPtr.Zero);
                        break;
                }
                
                
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            string nom, desc, plateforme, editeur;
            double prix=0;
            bool r = false;

            nom = Nom.Text;
            desc = Description.Text;
            plateforme = Plateforme.Text;
            editeur = Editeur.Text;
            try
            {
                prix = Double.Parse(Prix.Text);
                Prix.ForeColor = Color.Black;
            }
            catch(System.FormatException ex)
            {
                Prix.ForeColor = Color.Red;
                Prix.Focus();
            }
            string g = (string)boxGenre.SelectedItem;
            DateTime d = date.Value;
            r = Recondition.Checked;
            j = new Jeu(nom, desc, plateforme, g, editeur, prix, d, r);
            j.Photo = BPhoto.Image;

            if (j.Photo == null)
                Chemin.Text = "Veuillez selectionner une image";
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Visible = false;
                this.Dispose();
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Visible = false;
            this.Dispose();
        }

        private void Valider2_Click(object sender, EventArgs e)
        {
            string nom, desc, plateforme, editeur,etat;
            double prix=0;
            bool r,notice;

            nom = RNom.Text;
            desc = RDescription.Text;
            plateforme = RPlateforme.Text;
            editeur = REditeur.Text;
            try
            {
                prix = Double.Parse(RPrix.Text);
                RPrix.ForeColor = Color.Black;
            }
            catch (System.FormatException ex)
            {
                RPrix.ForeColor = Color.Red;
                RPrix.Focus();
            }
            string g = (string)boxGenre2.SelectedItem;
            DateTime d = Rdate.Value;
            etat = REtat.Text;
            r = BRecond.Checked;
            notice = Notice.Checked;

            j = new JeuRetro(nom, desc, plateforme, g, editeur, prix, d, r, etat, notice);
            j.Photo = Photo1.Image;
            ((JeuRetro)j).Galerie = Photo2.Image;

            if (j.Photo == null)
                Chemin.Text = "Veuillez selectionner une image";
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Visible = false;
                this.Dispose();
            }
        }
    }
}
