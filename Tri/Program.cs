using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tab = Sorting.FillTab();
            Sorting.PrintIndexAndValues(Tab);
            Console.Write("\n\n\n");
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            Sorting.SortingTab(Tab);
            Timer.Stop();
            Sorting.PrintIndexAndValues(Tab);
            Console.ReadKey();
        }
    }
}
