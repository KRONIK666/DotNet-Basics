using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = a + b + c + d + e;
            Console.WriteLine("The sum of entered number is: " + sum);
            Console.WriteLine();
        }
    }
}