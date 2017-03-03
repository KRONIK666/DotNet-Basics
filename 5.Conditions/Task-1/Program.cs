using System;

namespace Task_1
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

            int temp = 0;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("Number a: " + a);
                Console.WriteLine("Number b: " + b);
            }
            else
            {
                Console.WriteLine("Number a: " + a);
                Console.WriteLine("Number b: " + b);
            } Console.WriteLine();
        }
    }
}