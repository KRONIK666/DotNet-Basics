using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number one: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number two: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number three: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = a + b + c;
            Console.WriteLine("The sum of entered numbers is: " + sum);
            Console.WriteLine();
        }
    }
}