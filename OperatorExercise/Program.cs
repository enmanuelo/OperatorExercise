using System;

namespace OperatorExercise
{
    class Program
    {
        public static void Addition(int num1, int num2)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            if (num1 == 17 && num2 == 4)
            {
                Console.WriteLine($"{num1} + {num2} is {sum}");
            }
            else
            {
                Console.WriteLine($"The sum of these two number is probably not {sum}");
            }
        }
        public static void Subtraction(int num1, int num2)
        {
            int a = 17;
            int b = 4;
            int difference = a - b;
            if (num1 == 17 && num2 == 4)
            {
                Console.WriteLine($"{num1} - {num2} is {difference}");
            }
            else
            {
                Console.WriteLine($"The difference of these two number is probably not {difference}");
            }
        }
        public static void Multiplication(int num1, int num2)
        {
            int a = 17;
            int b = 4;
            int product = a * b;
            if (num1 == 17 && num2 == 4)
            {
                Console.WriteLine($"{num1} * {num2} is {product}");
            }
            else
            {
                Console.WriteLine($"The product of these two number is probably not {product}");
            }
        }
        public static void Division(int num1, int num2)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (num1 == 17 && num2 == 4)
            {
                Console.WriteLine($"{num1} / {num2} is {quotient} remainder {remainder}");
            }
            else
            {
                Console.WriteLine($"The quotient of these two number is probably not {quotient} remainder {remainder}");
            }
        }
        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static void Main(string[] args)
        {
            // Exercise 1:
            Addition(17, 4);
            Subtraction(17, 4);
            Multiplication(17, 4);
            Division(17, 4);

            // Exercise 2:
            Console.WriteLine("Enter radius of circle: ");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}");
        }
    }
}