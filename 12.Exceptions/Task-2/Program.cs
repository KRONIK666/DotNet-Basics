using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (end <= start + 10)
            {
                Console.WriteLine("Wrong number input!");
                Console.WriteLine();
            }
            else
            {
                ReadNumber(start, end);
                Console.WriteLine();
            }
        }

        static void ReadNumber(int start, int end)
        {
            int count = 1;
            int number;

            do
            {
                Console.Write("Number {0}: ", count);
                number = int.Parse(Console.ReadLine());

                if (number >= end || number <= start)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong number input!");
                    break;
                }
                else
                {
                    start = number;
                } count++;
            } while (count < 11);
        }
    }
}