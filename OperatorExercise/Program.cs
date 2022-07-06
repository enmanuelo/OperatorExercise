using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1:
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            // Exercise 2:
            Console.WriteLine("Enter radius of circle: ");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}");
        }

        //Create a method that will Calculate the area of a circle based on its radius
        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }

}