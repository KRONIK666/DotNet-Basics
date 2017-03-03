using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = 0;
            ulong b = 1;
            ulong next;

            Console.WriteLine("Your Fibonacci is:");
            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                next = a + b;
                b = a;
                a = next;
                Console.WriteLine(next);
            } Console.WriteLine();
        }
    }
}