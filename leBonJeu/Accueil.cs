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
    public partial class Accueil : Form
    {
        Catalogue cata;
        Panier<Produit> panier;
        Panier<Produit> listeP;//liste des produits à afficher
        int type;//définie le type de produit à filtrer
        Produit pcourant;//le dernier produit selectionné
        Genre g;//genre selectionnée dans le filtre
        public Accueil()
        {
            InitializeComponent();
            this.Size = new Size(1172, 674);

            cata = new Catalogue();
            cata.init();
            panier = new Panier<Produit>();
            pcourant = null;
            

            initPanier();
            initListePhoto();
            initListeGenre();
            type = 2;
            listeP = new Panier<Produit>();
            init_Menu(true);
            g = Genre.Autres;
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            if(pcourant!=null)
            {
                panier.ajout(pcourant);
                this.initListePhoto();
                info.Text = "Le jeu " + pcourant.Nom + " a été ajouté dans votre panier";
                BPhoto.Image = null;
                pcourant = null;
                this.Refresh();//rafraississement de l'affichage
            }
            else
            {
                info.Text = "Veuillez selectionner un jeu !";
            }
        }

        private void initListeGenre()
        {
            TreeNode nd;

            foreach(string s in Enum.GetNames(typeof(Genre)))
            {
                nd = new TreeNode(s);
                nd.Name = s;
                arbre.Nodes[2].Nodes.Add(nd);
            }
            boxGenre.DataSource = Enum.GetValues(typeof(Genre));
        }


        private void initPanier()
        {
            for(int i=0;i<4;i++)
            {
               // panier.ajout(cata.getAccessoireAt(i));
                //panier.ajout(cata.getFigurineAt(i));
                panier.ajout(cata.getJeuAt(i));
            }
        }

        private void initListePhoto()
        {
            listePhoto.ItemHeight = 120;
            this.listePhoto.DrawMode = DrawMode.OwnerDrawFixed;

            listePhoto.Items.Clear();
            for (int i=0;i<panier.count();i++)
            {
                Produit p = (Produit)panier.getElementAt(i);
                listePhoto.Items.Add(p.Photo);
            }
        }

        private void listePhoto_DrawItem(object sender, DrawItemEventArgs e)
        {
            ImageList liste = new ImageList();
            liste.ImageSize = new Size(118, 118);

            for(int i=0;i< panier.count(); i++)
            {
                Produit pr = (Produit)panier.getElementAt(i);
                liste.Images.Add(pr.Photo);
            }
            Point p = e.Bounds.Location;

            liste.Draw(e.Graphics, p, e.Index);
        }

        /**
         * methode qui affiche les contenus des jeux au milieu
         */

        private void miseAJourListe()
        {
            listeP = new Panier<Produit>();

            switch (type)
            {
                case 0:
                    foreach (Accessoire ac in cata.LstAccessoire.Liste)
                    {
                        listeP.ajout(ac);
                        
                    }
                    titre.Text = "Liste des Accessoires";
                    break;
                case 1:
                    foreach (Figurine ac in cata.LstFigurine.Liste)
                    {
                        listeP.ajout(ac);
                        titre.Text = "Liste de figurines";
                    }
                    break;
                case 2:
                    foreach (Jeu ac in cata.LstJeu.Liste)
                    {
                        listeP.ajout(ac);
                        
                    }
                    titre.Text = "Liste des jeux";
                    break;
                case 3:
                    LesJeux l = cata.getJeuByGenre(g);
                    foreach(Jeu j in l.Liste)
                    {
                        listeP.ajout(j);
                    }
                    titre.Text = "liste des jeux de genre : " + g;
                    break;
                case 4:
                    LesJeux lj = cata.getJeuRetro();
                    foreach (Jeu j in lj.Liste)
                    {
                        listeP.ajout(j);
                    }
                    titre.Text = "liste des jeux retro";
                    break;
            }
        }
        private void init_Menu(bool miseajour)
        {
            tab.Controls.Clear();
            if (miseajour)
            {
                this.miseAJourListe();
                info.Text = "";
            }
            affichage();
        }


        public void affichage()
        {
            int w = tab.Width / 5 - 10;

            for (int i = 0; i < listeP.count(); i++)
            {
                Produit p = listeP.getElementAt(i);

                //ajout panneau
                TableLayoutPanel pan = new TableLayoutPanel();
                pan.ColumnCount = 1;
                pan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                pan.RowCount = 2;
                pan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                pan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
                pan.Width = w;
                pan.Height = 200;
                //ajout label
                Label nomProduit = new Label();
                nomProduit.Text = p.Nom + " " + p.Prix + "$";
                nomProduit.ForeColor = Color.White;
                nomProduit.Dock = System.Windows.Forms.DockStyle.Bottom;
                pan.Controls.Add(nomProduit);
                //ajout image
                PictureBox img = new PictureBox();
                img.Name = p.Nom;
                img.Click += affiche_detail;//abonnement à un ecouteur lors du clic sur l'image
                img.MouseHover += Img_MouseHover;//abonnement à un ecouteur lors du passage de la souris
                img.Size = new Size(pan.Width - 5, pan.Width);
                img.Dock = System.Windows.Forms.DockStyle.Top;
                img.Image = p.Photo.GetThumbnailImage(img.Width, img.Height, null, IntPtr.Zero);
                pan.Controls.Add(img);

                tab.Controls.Add(pan);
            }
        }

        private void Img_MouseHover(object sender, EventArgs e)
        {
            string nom = ((PictureBox)sender).Name;
            Produit j = listeP.getElementByNom(new Jeu(nom));

            if(j!=null)
            {
                bulle.SetToolTip((PictureBox)sender, j.Desc);
            }
        }

        private void affiche_detail(object sender, EventArgs e)
        {
            string nom = ((PictureBox)sender).Name;//on prend le nom du jeu
            string s = "";
            Image img = null;

            if(this.last!=null)
                last.Parent.BackColor = Color.Transparent;
            last = (PictureBox)sender;
            ((PictureBox)sender).Parent.BackColor = Color.DarkGray;

            switch(type)
            {//on chercher le produit dans le catalogue selon le type
                case 0:
                    Accessoire a = cata.getAccessoireByNom(nom);
                    s = a.ToString();
                    pcourant = a;
                    break;
                case 1:
                    Figurine f = cata.getFigurineByNom(nom);
                    s = f.ToString();
                    pcourant = f;
                    break;
                default:
                    Jeu j = cata.getJeuByNom(nom);
                    pcourant = j;
                    if (j.GetType()==typeof(JeuRetro))
                        img = ((JeuRetro)j).Galerie;
                    s = j.ToString();
                    break;
            }
            if(img!=null)
                BPhoto.Image=img.GetThumbnailImage(BPhoto.Width, BPhoto.Height, null, IntPtr.Zero);
            else
                BPhoto.Image = null;
            info.Text = s;
        }

        private void listePhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listePhoto.SelectedIndex;
            pcourant = panier.getElementAt(i);
            Image img = null;

            if(pcourant.GetType()==typeof(JeuRetro))
            {
                img = ((JeuRetro)pcourant).Galerie;
            }
            info.Text = pcourant.ToString();

            if (img != null)
            {
                BPhoto.Image = img.GetThumbnailImage(BPhoto.Width, BPhoto.Height, null, IntPtr.Zero);
            }
            else
            {
                BPhoto.Image = null;
            }
        }

        private void bRetirer_Click(object sender, EventArgs e)
        {
            if(pcourant!=null)
            {
                panier.supprimer(pcourant);
                this.initListePhoto();
                info.Text = "Le jeu " + pcourant.Nom + " a été retiré dans votre panier";
                BPhoto.Image = null;
                pcourant = null;
                this.Refresh();
            }
            else
            {
                info.Text = "Veuillez selectionner un produit dans le panier";
            }
        }

        private void boxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
           g = (Genre)boxGenre.SelectedItem;
            type = 3;

            info.Text = "";
            BPhoto.Image = null;
            init_Menu(true);
            this.Refresh();
        }

        private void arbre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nd = e.Node;
            try
            {
                switch (nd.Name)
                {
                    case "accessoireNoeud":
                        type = 0;
                        init_Menu(true);break;
                    case "figurineNoeud":
                        type = 1;
                        init_Menu(true);break;
                    case "jeuNoeud":
                        type = 2;
                        init_Menu(true);break;
                    case "retroNoeud":
                        type = 4;
                        init_Menu(true);break;
                    case "croissant":
                        listeP.trieCroissant();
                        init_Menu(false);break;
                    case "decroissant":
                        listeP.trieDecroissant();
                        init_Menu(false);break;
                    default:
                        if (nd.Parent!=null&&nd.Parent.Name.Equals("genreNoeud"))
                        {
                            type = 3;
                            g = (Genre)Enum.Parse(typeof(Genre), nd.Name, true);
                        }
                        else
                            type = 2;
                        init_Menu(true);
                        break;
                }
            }
            catch
            {
                type = 2;
                init_Menu(true);
            }            
        }

        private void boxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = boxType.SelectedIndex;
            init_Menu(true);
            this.Refresh();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieJeuDlg diag = new SaisieJeuDlg();
            DialogResult res=diag.ShowDialog();//ouverture de la boite de dialogue

            if(res==DialogResult.OK)
            {
                Jeu j = diag.NewJeu;//on accede au jeu de la classe saisiejeudlg
                cata.AjoutJeu(j);//on l'ajoute dans le catalogue
                init_Menu(true);//on reaffiche la liste des jeux
                this.Refresh();
            }
        }

        private void lesJeuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisuJeuDlg diag = new VisuJeuDlg(cata.LstJeu);
            diag.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajDlg diag = new MajDlg(cata.LstJeu);
            DialogResult res = diag.ShowDialog();

            if(res==DialogResult.OK)
            {
                cata.LstJeu = diag.Liste;
                this.init_Menu(true);
                this.Refresh();
            }
        }

        private void Accueil_Resize(object sender, EventArgs e)
        {
        }
    }
}
