using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string number;
            int sum = 0;

            Console.Write("Enter a number: ");

            while ((number = Console.ReadLine()) != "")
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(number);
                numbers.Add(num);
                sum += num;
            } Console.WriteLine();

            Console.WriteLine("The sum of all numbers is: " + sum);
            Console.WriteLine("Result: " + (double)sum / numbers.Count);
            Console.WriteLine();
        }
    }
}