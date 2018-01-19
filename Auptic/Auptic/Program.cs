using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auptic
{
    class Program
    {
        public static void Methode(int[] t)
        {
            t[0] = t[0] + 24;
        }
        static void Main(string[] args)
        {
            int[] tabTest = new int[] { 12 };

            Methode(tabTest);
            Console.WriteLine("tabTest[0] à la fin: {0}", tabTest[0]);
            Console.ReadKey();
        }
    }
}
