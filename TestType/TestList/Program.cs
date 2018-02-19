using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestType
{
    class Program
    {
        static void Main(string[] args)
        {
            Write(33);
            Write(12.5);
            Console.ReadKey(true);
        }

        static void Write<T>(T val)
        {
            Console.WriteLine(val.ToString() + " est de type : " + typeof(T));
        }
    }
}
