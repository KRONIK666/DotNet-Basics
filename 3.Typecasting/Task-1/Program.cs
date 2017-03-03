using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("The number is EVEN!");
                Console.WriteLine();
            }
            else if (a % 2 == 1)
            {
                Console.WriteLine("The number is ODD!");
                Console.WriteLine();
            }
        }
    }
}