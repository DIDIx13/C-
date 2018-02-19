using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProduits
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p = new Produit("0001 - 100 - 18", 0, DateTime.Now);

            Livre l = new Livre("Vol sur la ville", "125-args-2535-22005-asfd-ffe", "Roman policier", "0001-100-18");
            Console.WriteLine(l.ToString());
            Console.WriteLine("\nPressez une touche pour terminer...");
            Console.ReadKey(true);
        }
    }
}
