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
            bool result;
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                result = true;
                Console.WriteLine("The number divides to 5: " + result);
            }
            else
            {
                result = false;
                Console.WriteLine("The number divides to 5: " + result);
            }

            if (num % 7 == 0)
            {
                result = true;
                Console.WriteLine("The number divides to 7: " + result);
            }
            else
            {
                result = false;
                Console.WriteLine("The number divides to 7: " + result);
            } Console.WriteLine();
        }
    }
}