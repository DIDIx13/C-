using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        enum Jours
        {

            Lundi = 1,
            Mardi = 2,
            Mercredi = 3,
            Jeudi = 4,
            Vendredi = 5,
            Samedi = 6,
            Dimanche = 7,

        }
        static void Main(string[] args)
        {
            DateTime Date = DateTime.Now;

            if (Date.DayOfWeek == DayOfWeek.Saturday ||
                Date.DayOfWeek == DayOfWeek.Sunday ||
                (Date.DayOfWeek == DayOfWeek.Monday && Date.Hour < 9) ||
                (Date.DayOfWeek == DayOfWeek.Friday && Date.Hour >= 18))
            {
                // nous sommes le week-end
                Hello.ShowWeekEnd();
            }
            else
            {
                // nous sommes en semaine
                if (Date.Hour >= 9 && Date.Hour < 18)
                {
                    // nous sommes dans la journée
                    Hello.ShowWeekDay();
                }
                else
                {
                    Hello.ShowWeekEvening();
                }
            }
            /*
             * In the case we wanted to use User.cs, here we wanted to use Environment.UserName
             * 
            User Darwin = new User();
            Darwin.setUser("Darwin");
            User Tyler = new User();
            Tyler.setUser("Tyler");
            User Jan = new User();
            Jan.setUser("Jan");
            */

            Console.WriteLine("Press a key to continue ...");
            Console.ReadKey();
        }
    }
}
