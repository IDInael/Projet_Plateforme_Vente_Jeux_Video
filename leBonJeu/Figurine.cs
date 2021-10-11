using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    class Figurine : Produit
    {
        private string reference;//pour savoir a quel jeu il fait reference

        public Figurine():base()
        {
            this.reference = "Default";
        }

        public Figurine(string nom, string desc,double prix):base(nom,desc,prix)
        {
            this.reference = "default";
        }

        public Figurine(String nom, string desc,double prix,string reff):base(nom,desc,prix)
        {
            this.reference = reff;
        }

        public string Reference {
            get { return this.reference; }
            set { this.reference = value; } 
        }

        public override string ToString()
        {
            string res = base.ToString();
            res +="Reference : "+ this.reference + "\n";
            return res;
        }
    }
}
