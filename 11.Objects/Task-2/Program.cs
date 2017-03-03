using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Random numbers = new Random();
            Console.Write("Randomly generated numbers in the interval 100-200: ");

            for (int i = 1; i <= 10; i++)
            {
                number = numbers.Next(100, 201);
                Console.Write(number + "; ");
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}