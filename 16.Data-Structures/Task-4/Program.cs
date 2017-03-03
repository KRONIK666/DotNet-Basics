using System;
using System.Collections.Generic;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Add a number: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    numbers.Add(num);
                }
                else
                {
                    continue;
                }
            } Console.WriteLine();

            Console.WriteLine("Positive numbers added to the list: ");
            Console.WriteLine();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}