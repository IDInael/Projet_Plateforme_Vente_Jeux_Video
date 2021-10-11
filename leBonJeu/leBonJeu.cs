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
    public partial class Fenetre : Form
    {
        LesJeux lstJeu;

        public Fenetre()
        {
            InitializeComponent();
            InitListeGenre();

            lstJeu = new LesJeux();
            lstJeu.init();
            InitListPhotos();
            initListJeux();
        }

        private void InitListeGenre()
        {
            this.ListeGenre.DataSource= Enum.GetValues(typeof(Genre));
        }

        private void InitListPhotos()
        {
            this.listPhoto.DrawMode = DrawMode.OwnerDrawFixed;
            foreach(Jeu j in lstJeu.LstJeu)
            {
                this.listPhoto.Items.Add(j.Photo);
            }
        }

        private void BTous_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach(Jeu j in lstJeu.LstJeu)
            {
                s += j.ToString() + "\n";
            }
            edition.Text = s;
        }

        private void initListJeux()
        {
            foreach(Jeu j in lstJeu.LstJeu)
            {
                ListeJeu.Items.Add(j.Nom);
            }
        }

        private void ListeJeu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jeu j = lstJeu.getJeuAt(ListeJeu.SelectedIndex);
            edition.Text = j.ToString();
        }

        private void BRetro_Click(object sender, EventArgs e)
        {
            LesJeux lj = lstJeu.getJeuRetro();
            string s = "";

            foreach(Jeu j in lj.LstJeu)
            {
                s += j.ToString() + "\n";
            }
            edition.Text = s;
        }

        private void ListeGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            LesJeux lj = lstJeu.getByGenre((Genre)ListeGenre.SelectedItem);
            string s = "";

            foreach (Jeu j in lj.LstJeu)
            {
                s += j.ToString() + "\n";
            }
            edition.Text = s;
        }

        private void jeuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisuJeuDlg diag = new VisuJeuDlg(this.lstJeu);
            diag.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifJeuDlg diag = new ModifJeuDlg(this.lstJeu);
            diag.ShowDialog();
        }
    }
}
