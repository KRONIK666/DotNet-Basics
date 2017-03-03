using System;

namespace Task_4
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

            int numbers = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    ++numbers;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Numbers between {0} and {1}: {2}", a, b, numbers);
            Console.WriteLine();
        }
    }
}