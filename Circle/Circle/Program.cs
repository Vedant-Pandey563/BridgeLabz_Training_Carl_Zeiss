using System;

namespace Circle
{
    class Circle_Details
    {
        private double radius;

        public Circle_Details(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Circumference: {GetCircumference()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle_Details circle = new Circle_Details(radius);

            Console.WriteLine("Circle details are:");
            circle.DisplayDetails();


        }
    }
}
