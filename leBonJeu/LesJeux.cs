using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    public class LesJeux
    {
        private List<Jeu> lstJeu;

        public LesJeux()
        {
            this.lstJeu = new List<Jeu>();
        }

        public List<Jeu> Liste
        {
            get { return this.lstJeu; }
        }
        public void ajoutJeu(Jeu j)
        {
            if (j != null)
            {
                this.lstJeu.Add(j);
            }
        }

        public void ajoutJeuAt(Jeu j, int i)
        {
            if (j != null && i < Taille)
            {
                this.lstJeu[i] = j;
            }
        }

        public void supprimer(Jeu j)
        {
            this.lstJeu.Remove(j);
        }

        /**
         * supprimer le jeu à l'index i
         */
        public void supprimer(int i)
        {
            if (i < Taille)
                this.lstJeu.RemoveAt(i);
        }

        /**
         * retourne le jeu dont le nom est passé en parametre s'il existe
         */
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


        public override String ToString()
        {
            String res = "";

            for (int i = 0; i < Taille; i++)
            {
                res += lstJeu[i].ToString() + "\n";
            }
            return res;
        }

        /**
         * renvoie le jeu à l'indice i
         */
        public Jeu getJeuAt(int i)
        {
            if (i < Taille)
                return lstJeu[i];
            else
                return null;
        }

        /**
         * trie rapide de la liste en ordre croissant selon le nom
         */
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

        /**
         * trie rapide de la liste de jeu en ordre decroissant
         */
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
                //ici on compare si le jeu à l'indice i est inferieur au jeu à l'indice end
                if (arr[i] < arr[end])
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

        public int partitionDecroissant(List<Jeu> arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                //ici on compare si le jeu à l'indice i est superieur au jeu à l'indice end
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
            quickSortCroissant(this.lstJeu, 0, Taille - 1);
        }

        public void trieDecroissant()
        {
            quickSortDecroissant(this.lstJeu, 0, Taille - 1);
        }

        public LesJeux getByGenre(Genre s)
        {
            LesJeux lj = new LesJeux();

            foreach (Jeu j in this.lstJeu)
            {
                if (j.getGenre == s)
                    lj.ajoutJeu(j);
            }
            return lj;
        }

        /**
         * renvoie la liste de tous les jeux retro
         */
        public LesJeux getJeuRetro()
        {
            LesJeux res = new LesJeux();

            foreach (Jeu j in this.lstJeu)
            {
                if (j.GetType() == typeof(JeuRetro))
                {
                    res.ajoutJeu(j);
                }
            }
            return res;
        }

        public void init()
        {
            //jeu action aventure
            Jeu j = new Jeu("GTA", "jeu de simulation", "PS3", "Action_aventure", "Take 2", 8.31, new DateTime(2013, 9, 17), false);
            j.Photo = Properties.Resources.gta;
            this.lstJeu.Add(j);

            j = new Jeu("Assasin's creed", "jeu d'infiltration", "PS3", "Action_aventure", "Ubisoft", 4.07, new DateTime(2007, 11, 15), true);
            j.Photo = Properties.Resources.assassin_creed;
            lstJeu.Add(j);

            j = new Jeu("Le seigneur des anneau", "La guerre du nord", "PS3", "Action_aventure", "Warner Interactive", 10.25, new DateTime(2011, 11, 3), true);
            j.Photo = Properties.Resources.seigneur_anneau;
            lstJeu.Add(j);

            j = new Jeu("Tintin", "Le secret de la licorne", "Wii", "Action_aventure", "Ubisoft", 7.97, new DateTime(2011, 10, 20), true);
            j.Photo = Properties.Resources.tintin;
            lstJeu.Add(j);

            j = new Jeu("Spider man", "The amazing spider man", "Xbox 360", "Action_aventure", "Activision", 11.28, new DateTime(2012, 6, 29), true);
            j.Photo = Properties.Resources.spider_man;
            lstJeu.Add(j);

            //jeu combat
            j = new Jeu("Naruto shippuden", "ultimate ninja 3", "PC", "Combat", "bandai namco", 5.06, new DateTime(210, 10, 15), true);
            j.Photo = Properties.Resources.naruto;
            lstJeu.Add(j);

            j = new Jeu("tekken 7", "combat personnel", "Xbox one", "Combat", "bandai namco", 21.95, new DateTime(2017, 6, 02), false);
            j.Photo = Properties.Resources.tekken;
            lstJeu.Add(j);

            j = new Jeu("FIght night champion", "jeu de box", "PS3", "Combat", "EA", 9.11, new DateTime(2011, 3, 4), false);
            j.Photo = Properties.Resources.fight;
            lstJeu.Add(j);

            //jeu de course
            j = new Jeu("Dirt rally", "", "Xbox 360", "Course", "Codemaster", 6.55, new DateTime(2009, 9, 10), true);
            j.Photo = Properties.Resources.dirt;
            lstJeu.Add(j);

            j = new Jeu("Mario kart", "", "DS", "Course", "Nintendo", 19.95, new DateTime(2006, 12, 1), false);
            j.Photo = Properties.Resources.mario_kart;
            lstJeu.Add(j);

            j = new Jeu("Forza horizon", "course auto", "PC", "Course", "Microsoft", 10.95, new DateTime(2012, 10, 23), true);
            j.Photo = Properties.Resources.forza;
            lstJeu.Add(j);

            j = new Jeu("blur", "course auto", "PC", "Course", "Activision", 10.45, new DateTime(2010, 05, 28), true);
            j.Photo = Properties.Resources.blur;
            lstJeu.Add(j);

            //jeu d'arcade

            j = new Jeu("Angry bird", "", "PC", "Arcade", "Juste for Games", 6.99, new DateTime(2012, 4, 1), true);
            j.Photo = Properties.Resources.bird;
            lstJeu.Add(j);

            j = new JeuRetro("Pac Man", "", "3DS", "Arcade", "bandai namco", 9.95, new DateTime(2011, 8, 26), true, "En bonne etat", true);
            j.Photo = Properties.Resources.pac_man;
            ((JeuRetro)j).Galerie = Properties.Resources.pac_man2;
            lstJeu.Add(j);

            //jeu compilation
            j = new Jeu("Far cry", "far cry 3 et 4", "PS3", "Action_RPG", "Ubisoft", 12.31, new DateTime(2015, 8, 27), false);
            j.Photo = Properties.Resources.far_cry;
            lstJeu.Add(j);

            j = new Jeu("1000 borne", "", "DS", "Societe", "Mindscape", 7.45, new DateTime(2008, 11, 14), false);
            j.Photo = Properties.Resources.borne;
            lstJeu.Add(j);

            j = new Jeu("Dragon ball z", "dbz : kakarot", "PS4", "Action_RPG", "bandai namco", 31.95, new DateTime(2020, 1, 17), false);
            j.Photo = Properties.Resources.dbz;
            lstJeu.Add(j);

            j = new JeuRetro("Batman", "", "PS2", "Action_RPG", "sunsoft", 15.95, new DateTime(1990, 9, 14), true, "en etat", true);
            j.Photo = Properties.Resources.batman;
            ((JeuRetro)j).Galerie = Properties.Resources.batman2;
            lstJeu.Add(j);

            j = new JeuRetro("tekken 3", "", "PS1", "Combat", "bandai namco", 15.95, new DateTime(1999, 1, 1), true, "en etat", false);
            j.Photo = Properties.Resources.tekken3;
            ((JeuRetro)j).Galerie = Properties.Resources.tetris2;
            lstJeu.Add(j);

            j = new Jeu("Nba2k 18", "Jeu de basketball", "Xbox one", "sport", "2k sports", 7.36, new DateTime(2017, 9, 15), false);
            j.Photo = Properties.Resources.nba;
            lstJeu.Add(j);

            j = new Jeu("Fifa 21", "foot", "Xbox one", "sport", "EA", 43.95, new DateTime(2020, 10, 9), false);
            j.Photo = Properties.Resources.fifa;
            lstJeu.Add(j);

            j = new JeuRetro("tetris", "", "DS", "Autres", "bandai namco", 4.99, new DateTime(1999, 12, 4), true, "en etat", false);
            j.Photo = Properties.Resources.tetris;
            ((JeuRetro)j).Galerie = Properties.Resources.tetris2;
            lstJeu.Add(j);
        }
    }
}
