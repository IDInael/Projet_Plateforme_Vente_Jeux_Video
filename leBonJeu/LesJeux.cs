using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leBonJeu
{
    public class LesJeux
    {
        private List<Jeu> lstJeu;

        public LesJeux()
        {
            this.lstJeu = new List<Jeu>();
        }

        public void ajoutJeu(Jeu j)
        {
            if (j != null)
            {
                this.lstJeu.Add(j);
            }
        }

        public List<Jeu> LstJeu
        {
            get { return this.lstJeu; }
        }

        public void supprimer(Jeu j)
        {
            this.lstJeu.Remove(j);
        }

        public Jeu getByNom(String s)
        {
            foreach (Jeu j in this.lstJeu)
            {
                if (j.Nom.Equals(s))
                    return j;
            }
            return null;
        }

        public int Taille
        {
            get { return this.lstJeu.Count(); }
        }

        public void init()
        {
            Jeu j = new Jeu("fifa", "", "ps4", "football", "EA Games", 16.99, new DateTime(1999, 12, 03), false);
            j.Photo = Properties.Resources.fifa;
            this.ajoutJeu(j);
            j = new Jeu("Tomb raideur", "", "PC", "action_aventure", "EA Games", 12, new DateTime(1999, 09, 21), false);
            j.Photo = Properties.Resources.tomb_raider;
            this.ajoutJeu(j);
            j = new Jeu("Avatar", "", "PS3", "Action_aventure", "EA Games", 6.99, new DateTime(2009, 06, 30), false);
            j.Photo = Properties.Resources.avatar;
            this.ajoutJeu(j);
            j = new Jeu("Super Mario", "", "Nintendo", "Compilation", "Bankai", 4.66, new DateTime(1995, 12, 15), false);
            j.Photo = Properties.Resources.super_mario;
            this.ajoutJeu(j);
            j=new JeuRetro("Pengo", "", "Nintendo", "Arcade", "Bankai", 2.66, new DateTime(1965, 08, 31), true, "Bonne etat", true);
            j.Photo = Properties.Resources.pengo;
            this.ajoutJeu(j);
            j = new JeuRetro("Tetris", "", "PSP", "Arcade", "Bankai", 5.0, new DateTime(1985, 05, 14), true, "En etat", true);
            j.Photo = Properties.Resources.tetris;
            this.ajoutJeu(j);
        }


        public override String ToString()
        {
            String res = "";

            for (int i = 0; i < Taille; i++)
            {
                res += lstJeu[i].ToString()+"\n";
            }
            return res;
        }

        public Jeu getJeuAt(int i)
        {
            if (i < Taille)
                return lstJeu[i];
            else
                return null;
        }

        public void quickSortCroissant(List<Jeu> arr, int start, int end)
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

        public void quickSortDecroissant(List<Jeu> arr, int start, int end)
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
        public int partitionCroissant(List<Jeu> arr, int start, int end)
        {
            
            for (int i = start; i < end; i++)
            {
                if (arr[i] < arr[end])
                {
                    Jeu tmp = arr[start];
                    arr[start]=arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            Jeu temp = arr[start];
            arr[start]=arr[end];
            arr[end]=temp;
            return start;
        }

        public int partitionDecroissant(List<Jeu> arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                if (arr[i] > arr[end])
                {
                    Jeu tmp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            Jeu temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return start;
        }

        public void trieCroissant()
        {
            quickSortCroissant(this.lstJeu, 0, Taille-1);
        }

        public void trieDecroissant()
        {
            quickSortDecroissant(this.lstJeu, 0, Taille - 1);
        }

        public LesJeux getByGenre(Genre s)
        {
            LesJeux lj = new LesJeux();

            foreach(Jeu j in this.lstJeu)
            {
                if (j.getGenre == s)
                    lj.ajoutJeu(j);
            }
            return lj;
        }

        public LesJeux getJeuRetro()
        {
            LesJeux res = new LesJeux();

            foreach(Jeu j in this.lstJeu)
            {
                if(j.GetType()== typeof(JeuRetro))
                {
                    res.ajoutJeu(j);
                }
            }
            return res;
        }
    }
}
