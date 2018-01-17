using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tri_bulle_avec_témoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tTab = RemplirTableau();
            AfficheTab(tTab);
            Console.WriteLine("\n--------\n");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            TriBulleTemoin(tTab);
            sw.Stop();
            AfficheTab(tTab);

            Console.WriteLine("\nLe temps ecoulé pour cet algorithme : {0}", sw.Elapsed);
            Console.ReadKey();
        }

        static int[] RemplirTableau()
        {
            const int LONGUEUR_TABLEAU = 10;

            int[] tTab = new int[LONGUEUR_TABLEAU];
            Random rnd = new Random();


            for (int i = 0; i < tTab.Length; i++)
            {
                int num = rnd.Next(-10, LONGUEUR_TABLEAU);
                tTab[i] = num;
            }

            return tTab;
        }

        

        static void Permute(ref int a, ref int b)
        {
            int tmp;

            tmp = a;
            a = b;
            b = tmp;
        }

        static void TriBulleTemoin(int[] tTab)
        {
            bool ordre = false;
            int i = 0;

            while (ordre == false && i <= tTab.Length)
            {
                ordre = true;
                for (int y = 0; y < tTab.Length - i - 1; y++)
                {
                    if (tTab[y] > tTab[y + 1])
                    {
                        Permute(ref tTab[y], ref tTab[y + 1]);
                        ordre = false;
                    }
                }
            }
        }


        static void AfficheTab(int[] tTab)
        {
            for (int i = 0; i < tTab.Length; i++)
            {
                Console.WriteLine("{0}", tTab[i]);
            }
        }
    }
}
