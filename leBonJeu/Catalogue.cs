using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    class Catalogue
    {
        private LesJeux lstJeu;//liste contenant les jeu dispo
        private LesAccessoires lstAccessoire;//liste contenant les accessoires
        private LesFigurines lstFigurine;//liste contenant les figurines
        private DateTime miseAJour;//derniere date de mise a jour

        public Catalogue()
        {
            this.lstJeu = new LesJeux();
            this.lstAccessoire = new LesAccessoires();
            this.lstFigurine = new LesFigurines();
            this.miseAJour = DateTime.Now;
        }

        public LesFigurines LstFigurine
        {
            get { return this.lstFigurine; }
        }

        public LesJeux LstJeu
        {
            get { return this.lstJeu; }
            set { this.lstJeu = value; }
        }

        public LesAccessoires LstAccessoire
        {
            get { return this.lstAccessoire; }
        }

        public DateTime MiseAJour
        {
            get { return this.miseAJour; }
            set { this.miseAJour = value; }//la mise a jour s'effectue au moment ou on fait appel à la fonction
        }


        /************************section liste des jeux*****************************/
        /**
         * methode pour avoir un jeu à une indice
         */
        public Jeu getJeuAt(int i)
        {
            return this.lstJeu.getJeuAt(i);
        }

        /**
         * methode pour chercher un jeu avec son nom
         */
        public Jeu getJeuByNom(string s)
        {
            return this.lstJeu.getByNom(s);
        }

        /**
         * renvoie une liste de jeu selon les genres
         */
        public LesJeux getJeuByGenre(Genre g)
        {
            return this.lstJeu.getByGenre(g);
        }

        public LesJeux getJeuRetro()
        {
            return this.lstJeu.getJeuRetro();
        }

        public void supprimerJeu(int i)
        {
            this.lstJeu.supprimer(i);
            MiseAJour= DateTime.Now;
        }

        public void supprimerJeu(Jeu j)
        {
            this.lstJeu.supprimer(j);
            MiseAJour = DateTime.Now;
        }

        public void trieCroissant()
        {
            this.lstJeu.trieCroissant();
            this.lstFigurine.trieCroissant();
            this.lstAccessoire.trieCroissant();
        }

        public void trieDecroissant()
        {
            this.lstJeu.trieDecroissant();
            this.lstFigurine.trieDecroissant();
            this.lstAccessoire.trieDecroissant();
        }

        /**
         * ajoute un nouveau jeu dans la liste
         */
        public void AjoutJeu(Jeu j)
        {
            this.lstJeu.ajoutJeu(j);
            MiseAJour = DateTime.Now;
        }



        /**************************section liste des figurines********************************/

        /**
         * return la figurine à l'indice i
         */
        public Figurine getFigurineAt(int i)
        {
            return this.lstFigurine.getFigurineAt(i);
        }

        /**
         * renvoie la figurine dont le nom est passé en parametre
         */
        public Figurine getFigurineByNom(String s)
        {
            return this.lstFigurine.getByNom(s);
        }

        /**
         * permet d'avoir la liste des figurines qui refere à un jeu en particulier
         */
        public LesFigurines getAllFigurineByRefference(string s)
        {
            return this.LstFigurine.getAllByReference(s);
        }

        /**
         * ajoute une nouvelle figurine dans la liste
         */
        public void ajoutFigurine(Figurine f)
        {
            this.LstFigurine.ajout(f);
            MiseAJour = DateTime.Now;
        }

        /**
         * supprime la figurine à l'indice i ou passe en parametre
         */
        public void supprimerFigurine(int i)
        {
            this.LstFigurine.supprimer(i);
            MiseAJour = DateTime.Now;
        }

        public void supprimerFigurine(Figurine f)
        {
            this.lstFigurine.supprimer(f);
            MiseAJour = DateTime.Now;
        }


        /************************************section liste des accessoires*****************************/


        /*
         * retourne l'accessoire à l'indice i 
         */

        public Accessoire getAccessoireAt(int i)
        {
            return this.lstAccessoire.getAccessoireAt(i);
        }

        /**
         * return l'accessoire dont le nom est passé en parametre
         */
        public Accessoire getAccessoireByNom(string s)
        {
            return this.lstAccessoire.getByNom(s);
        }

        /**
         * return une liste d'accessoire compatible avec le parametre
         */
        public LesAccessoires getAllAcessoireCompatible(string s)
        {
            return this.lstAccessoire.getAllAccessoireCompatible(s);
        }

        /**
         * memthode qui permet de supprimer un accesoire
         */
        public void supprimerAccessoire(int i)
        {
            this.lstAccessoire.supprimer(i);
            MiseAJour = DateTime.Now;
        }

        public void supprimerAccessoire(Accessoire a)
        {
            this.lstAccessoire.supprimer(a);
            MiseAJour = DateTime.Now;
        }

        /**
         * ajout d'une nouvelle accessoire
         */
        public void ajoutAccessoire(Accessoire a)
        {
            this.lstAccessoire.ajout(a);
            MiseAJour = DateTime.Now;
        }

        public void initCatalogue()
        {
            this.lstAccessoire.init();
            this.lstFigurine.init();
            this.lstJeu.init();
        }

        public override string ToString()
        {
            string res = "========================================================================\n";
            res += "****************************** CATALOGUE ******************************\n";
            res += "********* derniere date de mise a jour : " + this.miseAJour + " **********\n";
            res += "========================================================================\n\n";

            res += "***************************** CONTENU DE JEU ******************************\n";
            res += this.lstJeu.ToString()+"\n\n";

            res += "***************************** CONTENU D'ACCESSOIRE ***************************\n";
            res += this.LstAccessoire.ToString() + "\n\n";

            res += "***************************** CONTENU DE FIGURINE ****************************\n";
            res += this.lstFigurine.ToString() + "\n";

            return res;
        }

        public void init()
        {
            this.lstAccessoire.init();
            this.lstFigurine.init();
            this.lstJeu.init();
        }
    }
}
