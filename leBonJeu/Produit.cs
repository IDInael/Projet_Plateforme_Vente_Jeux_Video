using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LeBonJeu
{
    public abstract class Produit : IEquatable<Produit>, IComparable<Produit>
    {
        private String nom;
        private String desc;
        private double prix;
        private Image photo;

        public Produit()
        {
            this.nom = "Default";
            this.desc = "";
            this.prix = 0.0;
            this.photo = null;
        }

        public Produit(String n,String d,double p)
        {
            this.nom = n;
            this.desc = d;
            this.prix = p;
            this.photo = null;
        }

        public Image Photo { get; set; }
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

        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }


        public override bool Equals(Object p)
        {
            Produit j = p as Produit;
            /*
             * on considere que deux produit sont egaux s'ils sont de meme type et de meme nom
             */
            if (j != null)
                return this.Nom.Equals(j.Nom);
            else
                return false;
        }

        public bool Equals(Produit other)
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

        /**
        * permet de comparer deux objet de type jeu via l'interface IComparable
        * */
        public int CompareTo(Produit other)
        {
            if (other == null)
                return 7;
            else
                return Nom.CompareTo(other.Nom);
        }

        public static bool operator >(Produit j1, Produit j2)
        {
            if (j1 == null)
                return false;
            else
                return j1.CompareTo(j2) == 1;
        }

        public static bool operator >=(Produit j1, Produit j2)
        {
            if (j1 == null)
                return j2 == null;
            else
                return j1.CompareTo(j2) >= 0;
        }

        public static bool operator <=(Produit j1, Produit j2)
        {
            if (j1 == null)
                return j2 == null;
            else
                return j1.CompareTo(j2) <= 0;
        }

        public static bool operator <(Produit j1, Produit j2)
        {
            if (j1 == null)
                return false;
            else
                return j1.CompareTo(j2) == -1;
        }

        public override string ToString()
        {
            String res = "Nom : " + Nom+"\n";
            res += "Prix : " + Prix + "\n";
            //res += "Desc : " + Desc + "\n";
            return res;
        }
    }
}
