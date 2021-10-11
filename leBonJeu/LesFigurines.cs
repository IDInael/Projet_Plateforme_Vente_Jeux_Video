using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    class LesFigurines
    {
        List<Figurine> lstF;

        public LesFigurines()
        {
            this.lstF = new List<Figurine>();
        }

        public List<Figurine> Liste
        {
            get { return this.lstF; }
        }
        public int Taille
        {
            get { return this.lstF.Count(); }
        }

        public void ajout(Figurine f)
        {
            this.lstF.Add(f);
        }

        /**
         * supprime le figurine passé en parametre ou à l'indice i
         */
        public void supprimer(Figurine f)
        {
            this.lstF.Remove(f);
        }

        public void supprimer(int i)
        {
            if (i < Taille)
                this.lstF.RemoveAt(i);
        }

        public Figurine getByNom(String s)
        {
            foreach(Figurine f in this.lstF)
            {
                if (f.Nom.Equals(s))
                    return f;
            }
            return null;
        }

        public Figurine getFigurineAt(int i)
        {
            if (i < Taille)
                return this.lstF[i];
            else
                return null;
        }

        /**
         * cette methode renvoie la liste de figurine qui reference un nom d'un jeu passé en parametre
         */
        public LesFigurines getAllByReference(string reff)
        {
            LesFigurines res = new LesFigurines();

            foreach(Figurine f in this.lstF)
            {
                if (f.Reference.Equals(reff))
                    res.ajout(f);
            }
            return res;
        }

        /**
         * trie la liste des figurines suivant l'ordre alphabetique
         */
        public void quickSortCroissant(List<Figurine> arr, int start, int end)
        {
            int part = partitionCroissant(arr, start, end);
            if (part - 1 > start)
            {
                quickSortCroissant(arr, start, part - 1);
            }
            if (part + 1 < end)
            {
                quickSortCroissant(arr, part + 1, end);
            }
        }

        /**
         * un tri rapide qui trie la liste des figurines en ordre alphabetique inversse
         */
        public void quickSortDecroissant(List<Figurine> arr, int start, int end)
        {
            int part = partitionDecroissant(arr, start, end);
            if (part - 1 > start)
            {
                quickSortDecroissant(arr, start, part - 1);
            }
            if (part + 1 < end)
            {
                quickSortDecroissant(arr, part + 1, end);
            }
        }
        public int partitionCroissant(List<Figurine> arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                if (arr[i] < arr[end])
                {
                    Figurine tmp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            Figurine temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return start;
        }

        public int partitionDecroissant(List<Figurine> arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                if (arr[i] > arr[end])
                {
                    Figurine tmp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            Figurine temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return start;
        }

        public void trieCroissant()
        {
            quickSortCroissant(this.lstF, 0, Taille - 1);
        }

        public void trieDecroissant()
        {
            quickSortDecroissant(this.lstF, 0, Taille - 1);
        }

        public override string ToString()
        {
            string res = "";

            foreach(Figurine f in this.lstF)
            {
                res += f.ToString() + "\n";
            }

            return res;
        }

        public void init()
        {
            Figurine f = new Figurine("Neymar", "poster de neymar", 16, "fifa");
            f.Photo = Properties.Resources.fifa;
            this.ajout(f);
            f = new Figurine("Lara croft", "figurine de lara croft", 22, "tomb raider");
            f.Photo = Properties.Resources.tomb_raider;
            this.ajout(f);
            f = new Figurine("Mario bros", "playmobil mario", 30, "super mario");
            f.Photo = Properties.Resources.super_mario;
            this.ajout(f);
            f = new Figurine("Lego", "jeu de lego", 8, "tetris");
            f.Photo = Properties.Resources.tetris2;
            this.ajout(f);
        }
    }
}
