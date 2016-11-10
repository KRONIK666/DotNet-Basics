using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 535;
            int b = 1750;
            int aCheck = a / 100;
            int bCheck = b / 100;

            if (aCheck % 10 == 7)
            {
                Console.WriteLine("The third digit from right to left of number \"a\" is 7");
            }
            else
            {
                Console.WriteLine("The third digit from right to left of number \"a\" is not 7");
            }

            if (bCheck % 10 == 7)
            {
                Console.WriteLine("The third digit from right to left of number \"b\" is 7");
            }
            else
            {
                Console.WriteLine("The third digit from right to left of number \"b\" is not 7");
            } Console.WriteLine();
        }
    }
}