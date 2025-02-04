using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_31_1_2025_OOPS
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Circumference: {CalculateCircumference():F2}");
        }

        static void Main()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);
            circle.DisplayDetails();

        }
    }
}
