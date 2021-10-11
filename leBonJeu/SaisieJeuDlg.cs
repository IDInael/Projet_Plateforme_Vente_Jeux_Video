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
    public partial class SaisieJeuDlg : Form
    {
        Jeu j;
        public SaisieJeuDlg()
        {
            InitializeComponent();
            j = null;
            BGenre.DataSource = Enum.GetNames(typeof(Genre));
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            DialogResult res = diag.ShowDialog();
            if(res==DialogResult.OK)
            {
                string s = diag.FileName;
                Chemin.Text = s;
                Image img = Image.FromFile(s);
                BPhoto.Image = img.GetThumbnailImage(BPhoto.Width, BPhoto.Height, null,IntPtr.Zero);
                Console.WriteLine("test");
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            string nom, desc, plateforme, editeur;
            double prix;
            bool r = false;

            nom = LNom.Text;
            desc = LDesc.Text;
            plateforme = LPlateforme.Text;
            editeur = LEditeur.Text;
            prix = Double.Parse(LPrix.Text);
            string g = (string)BGenre.SelectedItem;
            DateTime d = date.Value;
            if (BRecondition.Checked)
                r = true;
            j = new Jeu(nom, desc, plateforme, g, editeur, prix, d, r);
            j.Photo = BPhoto.Image;

            Console.WriteLine(j);
        }
    }
}
