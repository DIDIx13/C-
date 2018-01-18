using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Hello
    {
        public static void ShowWeekEnd()
        {
            Console.WriteLine("Good wee-end" + Environment.UserName);
        }
        public static void ShowWeekDay()
        {
            Console.WriteLine("Hello " + Environment.UserName);
        }
        public static void ShowWeekEvening()
        {
            Console.WriteLine("Good evening " + Environment.UserName);
        }
    }
}
