using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int greater = Math.Max(a, b);
            Console.WriteLine("Greater number: " + greater);
            Console.WriteLine();
        }
    }
}