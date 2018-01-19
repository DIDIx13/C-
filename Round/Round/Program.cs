using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rond CercleACalculer = new Rond();


            Console.WriteLine("Le périmètre du rond vaut : " + CercleACalculer.Perimetre());
            Console.WriteLine("La surface du rond vaut : " + CercleACalculer.Surface());
            Console.WriteLine("Le diamètre du rond vaut : " + CercleACalculer.Diametre());
            Console.ReadKey();
        }
    }
}
