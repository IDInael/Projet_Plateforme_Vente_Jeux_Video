using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace leBonJeu
{
    public class Jeu : IEquatable<Jeu>, IComparable<Jeu>
    {
        private String nom;
        private String desc;
        private string plateforme;
        private Genre genre;
        private string editeur;
        private double prix;
        private DateTime date_Sortie;
        private Boolean recondition;
        private Image photo;

        public Jeu()
        {
            this.nom = "Default";
            this.desc = "";
            this.plateforme = "";
            this.genre = Genre.Default;
            this.editeur = "";
            this.prix = 0.0;
            this.date_Sortie = new DateTime();
            this.recondition = false;
            this.photo = null;
        }

        public Jeu(Jeu j)
        {
            if (j != null)
            {
                this.nom = j.Nom;
                this.desc = j.Desc;
                this.plateforme = j.Plateforme;
                this.genre = j.getGenre;
                this.editeur = j.editeur;
                this.prix = j.Prix;
                this.date_Sortie = j.Date_Sortie;
                this.recondition = j.Recondition;
                this.photo = j.Photo;
            }
        }

        public Jeu(String nom, String desc, String plateforme, String genre, String editeur, double prix, DateTime date, bool r)
        {
            this.nom = nom;
            this.desc = desc;
            this.plateforme = plateforme;
            this.GenreS = genre;
            this.editeur = editeur;
            this.prix = prix;
            this.date_Sortie = date;
            this.recondition = r;
            this.photo = null;
        }

        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public String Desc
        {
            get { return this.desc; }
            set { this.desc = value; }
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

        public String Editeur
        {
            get { return this.editeur; }
            set { this.editeur = value; }
        }

        public Genre getGenre
        {
            get { return this.genre; }
        }

        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
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

        public Image Photo
        {
            get { return this.photo; }
            set
            {
                if (value != null)
                {
                    this.photo = value;
                }
            }
        }

        public override string ToString()
        {
            String res = "Nom : " + this.nom + "\n";
            res += "Plateforme : " + this.plateforme + "\n";
            res += "Genre : " + GenreS + "\n";
            res += "Editeur : " + this.editeur + "\n";
            res += "Prix : " + Prix + "\n";
            res += "Sortie : " + this.date_Sortie.ToLongDateString() + "\n";
           // res += "\t" + this.desc + "\n";

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

        public override bool Equals(object obj)
        {
            Jeu j = obj as Jeu;

            if (j != null)
                return this.nom.Equals(j.Nom) && this.plateforme.Equals(j.Plateforme) && this.editeur.Equals(j.Editeur);
            else
                return false;
        }

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
        }

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

        public int CompareTo(Jeu other)
        {
            if (other == null)
                return 7;
            else
                return Nom.CompareTo(other.Nom);
        }

        public static bool operator >(Jeu j1, Jeu j2)
        {
            if (j1 == null)
                return false;
            else
                return j1.CompareTo(j2) == 1;
        }

        public static bool operator >=(Jeu j1, Jeu j2)
        {
            if (j1 == null)
                return j2 == null;
            else
                return j1.CompareTo(j2) >= 0;
        }

        public static bool operator <=(Jeu j1, Jeu j2)
        {
            if (j1 == null)
                return j2 == null;
            else
                return j1.CompareTo(j2) <= 0;
        }

        public static bool operator <(Jeu j1, Jeu j2)
        {
            if (j1 == null)
                return false;
            else
                return j1.CompareTo(j2) == -1;
        }


    }

    public enum Genre
    {
        Default, Plateforme, Action_RPG, Action_Aventure, Football, Course_Auto, Compilation,Arcade
    };
}
