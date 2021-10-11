using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    class LesAccessoires
    {
        private List<Accessoire> lstA;

        public LesAccessoires()
        {
            this.lstA = new List<Accessoire>();
        }

        public List<Accessoire> Liste
        {
            get { return this.lstA; }
        }
        public int Taille
        {
            get { return this.lstA.Count(); }
        }

        public void ajout(Accessoire a)
        {
            this.lstA.Add(a);
        }

        public void supprimer(Accessoire a)
        {
            this.lstA.Remove(a);
        }

        public void supprimer(int i)
        {
            if (i < Taille)
                this.lstA.RemoveAt(i);
        }
        public Accessoire getByNom(string s)
        {
            foreach(Accessoire a in this.lstA)
            {
                if (a.Nom.Equals(s))
                    return a;
            }
            return null;
        }

        public Accessoire getAccessoireAt(int i)
        {
            if (i < Taille)
                return this.lstA[i];
            else
                return null;
        }

        public void quickSortCroissant(List<Accessoire> arr, int start, int end)
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

        public void quickSortDecroissant(List<Accessoire> arr, int start, int end)
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
        public int partitionCroissant(List<Accessoire> arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                if (arr[i] < arr[end])
                {
                    Accessoire tmp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            Accessoire temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return start;
        }

        public int partitionDecroissant(List<Accessoire> arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                if (arr[i] > arr[end])
                {
                    Accessoire tmp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            Accessoire temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return start;
        }

        public void trieCroissant()
        {
            quickSortCroissant(this.lstA, 0, Taille - 1);
        }

        public void trieDecroissant()
        {
            quickSortDecroissant(this.lstA, 0, Taille - 1);
        }

        public override string ToString()
        {
            string res = "";

            foreach (Accessoire f in this.lstA)
            {
                res += f.ToString() + "\n";
            }

            return res;
        }

        /**
         * return tous les accesoires compatible avec le nom passé en parametre
         */
        public LesAccessoires getAllAccessoireCompatible(string s)
        {
            LesAccessoires res = new LesAccessoires();
            foreach(Accessoire a in this.lstA)
            {
                if (a.Compatibilite.Equals(s))
                    res.ajout(a);
            }
            return res;
        }

        public void init()
        {
            Accessoire a = new Accessoire("Tshirt", "noir", 22);
            a.Photo = Properties.Resources.shirt;
            this.ajout(a);
            a = new Accessoire("Manette ps4", "", 26, "PS4");
            a.Photo = Properties.Resources.manette;
            this.ajout(a);
            a = new Accessoire("Casque bluetooth", "", 50, "PC");
            a.Photo = Properties.Resources.casque;
            this.ajout(a);
            a = new Accessoire("Manette", "sans fil", 60, "PC");
            a.Photo = Properties.Resources.manette2;
            this.ajout(a);
        }
    }
}
