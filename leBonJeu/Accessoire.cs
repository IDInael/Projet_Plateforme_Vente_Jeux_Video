using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LeBonJeu
{
    public class Accessoire : Produit
    {
        private string compatibilite;//le plateforme ou console compatible avec l'accessoire

        public Accessoire():base()
        {
            this.compatibilite = "";
        }

        public Accessoire(string nom, string desc,double prix):base(nom,desc,prix)
        {
            this.compatibilite = "";
        }

        public Accessoire(string nom, string desc, double prix,string c) : base(nom, desc, prix)
        {
            this.compatibilite = c;
        }

     

        public string Compatibilite
        {
            get { return this.compatibilite; }
            set { this.compatibilite = value; }
        }

        public override string ToString()
        {
            string res = base.ToString();
            res += "Compatible : "+this.compatibilite;
            
            return res + "\n";
        }
    }
}
