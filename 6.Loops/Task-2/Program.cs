using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 || i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            } Console.WriteLine();
        }
    }
}