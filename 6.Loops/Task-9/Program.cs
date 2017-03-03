using System;
using System.Collections.Generic;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the list: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Random randomNum = new Random();
            Console.WriteLine();

            for (int i = 1; i < n; i++)
            {
                int temp = randomNum.Next(1, n);

                if (list.Contains(temp))
                {
                    i--;
                }
                else
                {
                    list.Add(temp);
                }
            }

            Console.WriteLine("Randomized numbers from 1 to n:");
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}