using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Affiche un compteur qui part de iMin et est incrémenté d'iPas tant qu'il ne dépasse pas iMax
             */
            Console.Write("\nCe programme permet d'énumerer tous les nombres entre deux variables selon un nombre de pas donné.\n\n");
            Console.Write("Entrez un nombre : ");
            int iMax = 0;
            int iMin = 0;
            int iPas = 0;
            try
            {
                iMin = Convert.ToInt32(Console.ReadLine());
                while (iMax < (iMin + 45))
                {
                    Console.Write("Entrez un nombre plus grand de 45 minimum à votre premier nombre : ");
                    iMax = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Entrez un troisième nombre à présent qui définira le nombre de pas : ");
                do
                {
                    //Console.Write("Entrez une valeur correcte");
                    iPas = Convert.ToInt32(Console.ReadLine());

                } while (iPas >= ((iMax - iMin) / 10) && iPas > 1);

                for (int i=iMin; iMin<=iMax;iMin+=iPas)
                {
                    Console.WriteLine("{0}",iMin);
                }

            }
            catch {Console.WriteLine("Saisie incorrecte !\n");}
            
            Console.WriteLine("\nPressez une touche pour fermer le programme ...");
            Console.ReadKey();
        }
    }
}
