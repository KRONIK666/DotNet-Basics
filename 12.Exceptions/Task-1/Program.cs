using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            try
            {
                if (num >= 0)
                {
                    Console.WriteLine("Result: " + Math.Sqrt(num));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Result is invalid!");
                    Console.WriteLine();
                }
            }
            finally
            {
                if (num < 0)
                {
                    Console.WriteLine("Invalid number!");
                    Console.WriteLine();
                }

                Console.WriteLine("Good Bye!");
                Console.WriteLine();
            }
        }
    }
}