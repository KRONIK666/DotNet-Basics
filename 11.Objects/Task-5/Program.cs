using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a side of the rectangular triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b side of the rectangular triangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The hypotenuse c of the rectangular triangle is: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine();
        }
    }
}