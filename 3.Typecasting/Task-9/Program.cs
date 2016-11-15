using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the interval 1 < 100: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i == number)
                {
                    Console.WriteLine("The number is prime!");
                    Console.WriteLine();
                }
                else if (i != 1 && i != number && number % i == 0)
                {
                    Console.WriteLine("The number is not prime!");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}