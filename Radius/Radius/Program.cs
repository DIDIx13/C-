using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radius
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle round;
            round = new Circle();
            Console.Write("You can insert the circle's radius : ");
            round.Init(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("\n\nRadius: {0}", round.getRadius());
            Console.WriteLine("Diameter: {0}", round.CalculationDiameter());
            Console.WriteLine("Perimeter: {0}", round.CalculationPerimeter());
            Console.WriteLine("Surface: {0}", round.CalculationSurface());
            Console.WriteLine("\nPress a key to exit ...");
            Console.ReadKey();
        }

        /// <summary>
        ///     Taking the radius to calculate him.
        /// </summary>
        /// <param></param>
        /// <returns>All the value to the user</returns>

        public class Circle
        {
            //private double dblShow;
            private double dblRadius;
            public void Init(double radius)
            {
                setRadius(radius);
                CalculationDiameter();
                CalculationPerimeter();
                CalculationSurface();
                //Show();
            }
            public void setRadius(double r)
            {
                this.dblRadius = r;
            }
            public double getRadius()
            {
                return this.dblRadius;
            }
            public double CalculationDiameter()
            {
                double radius = getRadius();
                return radius + radius;
            }
            public double CalculationPerimeter()
            {
                double radius = getRadius();
                double Diameter = radius + radius;
                return Diameter * Math.PI;
            }
            public double CalculationSurface()
            {
                double radius = getRadius();
                radius = radius * radius;
                return radius * Math.PI;
            }
            /* public void Show()
             {
                 Console.WriteLine("radius: {0}",getradius());
                 Console.WriteLine("Diameter: {0}",CalculationDiameter());
                 Console.WriteLine("Perimeter: {0}",CalculationPerimeter());
                 Console.WriteLine("Surface: {0}",CalculationSurface());
                 Console.ReadKey();
             }*/
        }
    }
}
