using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LeBonJeu
{
    public class Jeu : Produit
    {
        private string plateforme;
        private Genre genre;
        private string editeur;
        private DateTime date_Sortie;
        private Boolean recondition;

        public Jeu() : base()
        {
            this.plateforme = "";
            this.genre = Genre.Autres;//genre par defaut
            this.editeur = "";
            this.date_Sortie = DateTime.Today;//date par defaut est la date du jour
            this.recondition = false;
        }

        public Jeu(string s) : base()
        {
            this.Nom = s;
        }

        public Jeu(Jeu j) : base()
        {
            if (j != null)
            {
                this.Nom = j.Nom;
                this.Desc = j.Desc;
                this.Prix = j.Prix;
                this.plateforme = j.Plateforme;
                this.genre = j.getGenre;
                this.editeur = j.editeur;
                this.date_Sortie = j.Date_Sortie;
                this.recondition = j.Recondition;
                this.Photo = j.Photo;
            }
        }

        public Jeu(String nom, String desc, String plateforme, String genre, String editeur, double prix, DateTime date, bool r) : base(nom, desc, prix)
        {
            this.plateforme = plateforme;
            this.GenreS = genre;
            this.editeur = editeur;
            // this.prix = prix;
            this.date_Sortie = date;
            this.recondition = r;
        }



        public String Plateforme
        {
            get { return this.plateforme; }
            set { this.plateforme = value; }
        }

        public String GenreS
        {
            get { return Enum.Format(typeof(Genre), genre, "g"); }
            set { this.genre = (Genre)Enum.Parse(typeof(Genre), value, true); }
        }

        public Genre GenreG
        {
            set { this.genre = value; }
        }

        public String Editeur
        {
            get { return this.editeur; }
            set { this.editeur = value; }
        }

        public Genre getGenre
        {
            get { return this.genre; }
        }

        public int indexGenre
        {
            get { return (int)this.genre; }
        }



        public DateTime Date_Sortie
        {
            get { return this.date_Sortie; }
            set { this.date_Sortie = value; }
        }

        public Boolean Recondition
        {
            get { return this.recondition; }
            set { this.recondition = value; }
        }


        public override string ToString()
        {
            String res = base.ToString();
            res += "Plateforme : " + this.plateforme + "\n";
            res += "Genre : " + GenreS + "\n";
            res += "Editeur : " + this.editeur + "\n";
            res += "Sortie : " + this.date_Sortie.ToLongDateString() + "\n";
            res += "Jeu reconditionné : " + this.Recondition;
            res += "\n\"" + this.Desc + "\"\n";

            return res;
        }

        public virtual void Saisie()
        {
            Console.WriteLine(" Saisie de données du nouveau jeu: ");
            Console.Write(" Nom : "); Nom = Console.ReadLine();
            Console.Write(" Plateforme : "); Plateforme = Console.ReadLine();
            Console.Write(" Genre : "); GenreS = Console.ReadLine();
            Console.Write(" Editeur : "); Editeur = Console.ReadLine();
            Console.Write(" Prix : "); Prix = Double.Parse(Console.ReadLine());
            Console.Write(" Date de sortie (jj/mm/aaaa) : "); Date_Sortie = DateTime.Parse(Console.ReadLine());
            Console.Write(" Description : "); Desc = Console.ReadLine();
        }

        /**
         * surcharge de la methode equals de IEquatable
         *
        
        public override bool Equals(object obj)
        {
            Jeu j = obj as Jeu;
            /*
             * on considere que deux jeux sont les memes s'ils ont le meme nom et peut se jouer sur le meme plateforme
             *
            if (j != null)
                return this.Nom.Equals(j.Nom) && this.plateforme.Equals(j.Plateforme);
            else
                return false;
        }

        /**
         * methode equals de la classe jeu
         *
        public bool Equals(Jeu other)
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return Nom.Equals(other.Nom);
            }
        }*/

        public static bool operator ==(Jeu j1, Jeu j2)
        {
            if ((Object)j1 == null)
                return (Object)j2 == null;
            else
                return j1.Equals(j2);
        }

        public static bool operator !=(Jeu j1, Jeu j2)
        {
            return !(j1 == j2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }

    public enum Genre
    {
        Action_aventure, Action_RPG, Arcade, Combat, Course, Societe, sport, Autres
    };
}
