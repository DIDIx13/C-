using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri
{
    class Sorting
    {
        public static int[] FillTab()
        {
            const int SIZE = 10;

            int[] Tab = new int[SIZE];
            Random rnd = new Random();

            for (int i = 0; i < Tab.Length; i++)
            {
                int num = rnd.Next(-10, SIZE);
                Tab[i] = num;
            }
            return Tab;
        }

        public static void Reverse(ref int a, ref int b)
        {
            int tmp;

            tmp = a;
            a = b;
            b = tmp;
        }

        public static void SortingTab(int[] Tab)
        {
            bool b = false;

            while (b == false)
            {
                b = true;
                for (int y = 0; y < Tab.Length - 1; y++)
                {
                    if (Tab[y] > Tab[y + 1])
                    {
                        Reverse(ref Tab[y], ref Tab[y + 1]);
                        b = false;
                    }
                }
            }
        }

        public static void PrintIndexAndValues(int[] Tab)
        {
            for (int i = Tab.GetLowerBound(0); i <= Tab.GetUpperBound(0); i++)
            {

                Console.WriteLine("\t[{0}]:\t{1}", i, Tab.GetValue(i));
            }
        }
    }
}
