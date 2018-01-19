using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.setName("Ameli");
            p1.setFirstname("Darwin");
            p1.setDateNaissance("06.01.2000");
            Console.WriteLine(p1.getAge());
            Console.ReadKey();
        }
    }
    public class Personne
    {
        private string strName;
        private string strFirstname;
        private DateTime _dateNaissance;

        public void setDateNaissance(string date)
        {
            this._dateNaissance = DateTime.Parse(date, System.Globalization.CultureInfo.CurrentCulture);

        }
        public void setName(string Name)
        {
            this.strName = Name;
        }
        public void setFirstname(string Firstname)
        {
            this.strFirstname = Firstname;
        }
        public int getAge()
        {
            DateTime today = DateTime.Today; // Save today's date..
            
            int age = today.Year - _dateNaissance.Year; // Calculate the age.

            return age; 
        }
    }
}
