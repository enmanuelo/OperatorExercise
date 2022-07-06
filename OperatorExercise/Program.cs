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
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} + {b} is {sum}");
                Console.WriteLine($"{a} - {b} is {difference}");
                Console.WriteLine($"{a} x {b} is {product}");
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }
            else
            {
                Console.WriteLine($"The sum of these two number is probably not {sum}");
                Console.WriteLine($"The difference of these two numbers is probably not {difference}");
                Console.WriteLine($"The product of these two numbers is probably not {product}");
                Console.WriteLine($"The quotient of these two numbers is probably not {quotient} remainder {remainder}");
            }

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