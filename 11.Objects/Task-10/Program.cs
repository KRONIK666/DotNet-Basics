using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "12 205 88 75 15 117";
            Console.WriteLine("Get the sum of following numbers: " + numbers);
            Console.WriteLine();

            int sum = 0;
            string[] splitNumbers = numbers.Split(' ');

            for (int i = 0; i < splitNumbers.Length; i++)
            {
                sum = sum + Convert.ToInt32(splitNumbers[i]);
            }

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine();
        }
    }
}