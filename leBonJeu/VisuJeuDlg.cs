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
    public partial class VisuJeuDlg : Form
    {
        LesJeux lj;
        public VisuJeuDlg()
        {
            InitializeComponent();
            this.lj = new LesJeux();
        }

        public VisuJeuDlg(LesJeux liste)
        {
            InitializeComponent();
            this.lj = liste;
            initArbre();
            initListe();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
        }

        private void initArbre()
        {
            TreeNode nd,nf;//noeud parent et noeud fils
            foreach(Genre g in Enum.GetValues(typeof(Genre)))
            {
                LesJeux liste = lj.getByGenre(g);
                String s= Enum.Format(typeof(Genre), g, "g");
                nd = new TreeNode(s);

                foreach(Jeu j in liste.Liste)
                {
                    nf = new TreeNode(j.Nom);
                    nd.Nodes.Add(nf);
                }
                Arbre.Nodes.Add(nd);
            }
        }

        private void initListe()
        {
            foreach(Jeu j in lj.Liste)
            {
                liste.Items.Add(j.Nom);
            }
        }

        private void Fermer_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
        }

        private void Arbre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            String nom = node.Text;
            Jeu j = lj.getByNom(nom);
            afficheJeu(j);
        }

        private void afficheJeu(Jeu j)
        {
            if(j!=null)
            {
                Galerie.Image = null;
                Edition.Text = j.ToString();
                Photo.Image = j.Photo.GetThumbnailImage(Photo.Width, Photo.Height, null, IntPtr.Zero);

                if(j.GetType()==typeof(JeuRetro))
                {
                    Image img = ((JeuRetro)j).Galerie;
                    if (img != null)
                        Galerie.Image = img.GetThumbnailImage(Galerie.Width, Galerie.Height, null, IntPtr.Zero);
                    else
                        Galerie.Image = img;
                }
                
            }
        }



        private void liste_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int i = liste.SelectedIndex;
            Jeu j = lj.getJeuAt(i);
            afficheJeu(j);
        }
    }
}
