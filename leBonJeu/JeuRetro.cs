using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace leBonJeu
{
    class JeuRetro : Jeu
    {
        private String etat;
        private bool notice;
        private List<Image> galerie;

        public String Etat 
        {
            get { return this.etat; }
            set { this.etat = value; } 
        }
        public bool Notice 
        { get { return this.notice; }
            set { this.notice = value; }
        }
        public List<Image> Galerie { get; set; }

        public JeuRetro() : base()
        {
            Etat = "";
            Notice = false;
            Galerie = new List<Image>();
        }

        public JeuRetro(String nom, String desc, String plateforme, String genre, String editeur, double prix, DateTime date, bool r, String etat, bool notice) : base(nom, desc, plateforme, genre, editeur, prix, date, r)
        {
            Etat = etat;
            Notice = notice;
            Galerie = new List<Image>();
        }

        public JeuRetro(JeuRetro j) : base(j)
        {
            Etat = j.Etat;
            Notice = j.Notice;
            Galerie = j.Galerie;
        }

        public override void Saisie()
        {
            base.Saisie();
            Console.Write("Etat : ");Etat = Console.ReadLine();
            Console.Write("Notice : ");Notice = Boolean.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            String res = base.ToString();
            res += "Etat : " + this.Etat;
            res += "\nNotice : " + this.Notice+"\n\n";
            return res;
        }

    }
}
