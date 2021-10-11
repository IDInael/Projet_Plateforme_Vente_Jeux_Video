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
    public partial class VisuJeuDlg : Form
    {
        private LesJeux lstJeu;
        public VisuJeuDlg()
        {
            InitializeComponent();
            initArbre();
        }

        public VisuJeuDlg(LesJeux lj)
        {
            InitializeComponent();
            this.lstJeu = lj;
            initArbre();
        }

        private void initArbre()
        {
            foreach (Genre cr in Enum.GetValues(typeof(Genre)))
            {
                TreeNode n0 = new TreeNode(cr.ToString());
                LesJeux lj = lstJeu.getByGenre(cr);
                foreach (Jeu j in lj.LstJeu)
                {
                    TreeNode n1 = new TreeNode(j.Nom);
                    n0.Nodes.Add(n1);
                }
                arbre.Nodes.Add(n0);
            }
        }

        private void arbre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tv = (TreeView)sender;
            TreeNode nd = tv.SelectedNode;
            Jeu j = this.lstJeu.getByNom(nd.Text);

            if(j!=null)
            {
                edition.Text = j.ToString();
                Image img = j.Photo;
                image.Image=img.GetThumbnailImage(image.Width, image.Height, null, IntPtr.Zero);
            }
        }
    }
    
}
