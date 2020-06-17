using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Calcul
    {
        public static int CalculSommeEntiers(int Départ, int Arrivée)
        {
            int resulat = 0;
            for (int i = Départ; i <= Arrivée; i++)
            {
                resulat += i;
            }
            return resulat;
        }

        public static double CalculMoyenne(List<double> liste)
        {
            double somme = 0;
            foreach (double valeur in liste)
            {
                somme += valeur;
            }
            return somme / liste.Count; // liste.Count ne sert pas à obtenir la taille de la liste mais aux nombres d'éléments contenus.
        }

        /*
        ###########################################################################
        ##                                                                       ##
        ##         Ici j'ai crée le même principe mais avec un boucle for        ##
        ## J'ai utilié foreach car il est beaucoup plus simple à comprendre ici  ##
        ##                                                                       ##
        ###########################################################################
        *
        * static double CalculMoyenne(List<double> liste)
        * {
        *     double somme = 0;
        *     for (int i = 0; i < liste.Count; i++)
        *     {
        *         somme += liste[i];
        *    }
        *    return somme / liste.Count;
        * }
        *
        */

        public static int CalculSommeIntersection()
        {

            // Un dictionnaire aurait très bien pus être imaginable dans ce contexte.
            List<int> multiplesDe3 = new List<int>();
            List<int> multiplesDe5 = new List<int>();
            const int MultipleMax = 100; // Plus haut multiple possible

            for (int i = 3; i <= MultipleMax; i += 3) // On remplit la liste multiplesDe3 avec tous les multiples de trois
            {
                multiplesDe3.Add(i);
            }

            for (int i = 5; i <= MultipleMax; i += 5) // On remplit la liste multiplesDe3 avec tous les multiples de cinq
            {
                multiplesDe5.Add(i);
            }

            int somme = 0;

            foreach (int m3 in multiplesDe3)
            {
                foreach (int m5 in multiplesDe5)
                {
                    if (m3 == m5)
                        somme += m3;
                }
            }
            return somme;
        }
    }
}
