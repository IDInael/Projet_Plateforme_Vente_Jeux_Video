using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    class Panier<T> where T:IComparable<T>
    {
        private int capa;//capacité du panier
        private int nb;//nb element courant
        private T[] elt;//tableau contenant l'element de type T

        public Panier()
        {
            this.nb = 0;
            this.capa = 50;
            this.elt = new T[this.capa];
        }

        public Panier(int max)
        {
            this.nb = 0;
            this.capa = max;
            this.elt = new T[capa];
        }

        /**
         * renvoie le nombre d'element dans le panier
         */
        public int count()
        {
            return this.nb;
        }

        public int capacity()
        {
            return this.capa;
        }

        /**
         * permet d'ajouter un element de type T dans la panier
         */
        public void ajout(T p)
        {
            //pour eviter le doublons il faut que p n'est pas deja dans le panier
            if(this.nb<capa&& !this.contient(p))
            {
                elt[nb] = p;
                nb++;
            }
            else
            {
                Console.WriteLine("Operation impossible ! Le panier est plein ou l'element est deja dans le panier...");
            }
        }

        /**
         * methode qui supprime l'objet p et decale les elements de la liste vers la gauche
         */
        public void supprimer(T p)
        {
            bool found = false;
            int i = 0;
            while (!found && i < nb)
            {
                if (elt[i].Equals(p))
                {
                    found = true;
                    elt[i] = default(T);
                }
                else
                    i++;
            }

            if(found)
            {
                for(int j=i;j<this.nb;j++)
                {
                    elt[j] = elt[j + 1];//ajustement des elements restant dans le tableau
                }
                nb--;//mise a jour du nombre d'element
            }
        }

        public void supprimer(int i)
        {
            if(i<this.nb)
            {
                elt[i] = default(T);

                for (int j = i; j < this.nb; j++)
                {
                    elt[j] = elt[j + 1];//ajustement des elements restant dans le tableau
                }
                nb--;//mise a jour du nombre d'element
            }
        }

        /**
         * renvoie tru si l'element passé en parametre est contenu dans le tableau
         */
        public Boolean contient(T p)
        {
            bool found = false;
            int i = 0;
            while(!found&&i<nb)
            {
                if (elt[i].Equals(p))
                    found = true;
                else
                    i++;
            }
            return found;
        }

        /**
         * methode qui permet de chercher 
         */
        public T getElementAt(int i)
        {
            if (i < this.nb)
                return elt[i];
            else
                return default(T);
        }

        public T getElementByNom(T nom)
        {
            bool found = false;
            int i = 0;
            T res = default(T);
            while (!found && i < nb)
            {
                if (elt[i].Equals(nom))
                {
                    found = true;
                    res = elt[i];
                }
                else
                    i++;
            }
            return res;
        }
        /**
         * methode qui implemente l'algorithme du tri rapide pour trier le tableau en ordre croissant suivant l'ordre de l'alphabet
         */
        public void quickSortCroissant(T[] arr, int start, int end)
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
        public int partitionCroissant(T[] arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                if (arr[i].CompareTo(arr[end])==-1)//teste si l'élément à l'indice i est inferieur à l'élément à l'indice end
                {
                    T tmp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            T temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return start;
        }
        public void trieCroissant()
        {
            quickSortCroissant(elt, 0, nb - 1);
        }

        public void quickSortDecroissant(T[] arr, int start, int end)
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
        public int partitionDecroissant(T[] arr, int start, int end)
        {

            for (int i = start; i < end; i++)
            {
                if (arr[i].CompareTo(arr[end]) == 1)//teste si l'élément à l'indice i est superieur à l'élément à l'indice end
                {
                    T tmp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = tmp;
                    start++;
                }
            }
            T temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return start;
        }

        public void trieDecroissant()
        {
            quickSortDecroissant(elt, 0, nb - 1);
        }

        public override string ToString()
        {
            String res = "::: Contenu du panier :::\n";
            for(int i=0;i<nb;i++)
            {
                res += "type : "+elt[i].GetType()+"\n";
                res += elt[i].ToString()+"\n";
            }
            return res;
        }

        public void ajoutCollection(List<T> liste)
        {
            if (liste.Count+this.nb < this.capa)
            {
                for(int i=0;i<liste.Count;i++)
                {
                    elt[i + nb] = liste[i];
                }
                nb += liste.Count;
            }
        }
    }
}
