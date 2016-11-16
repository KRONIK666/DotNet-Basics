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
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (GetLastDigit(num))
            {
                case 0:
                    Console.WriteLine("Last digit is: zero");
                    break;
                case 1:
                    Console.WriteLine("Last digit is: one");
                    break;
                case 2:
                    Console.WriteLine("Last digit is: two");
                    break;
                case 3:
                    Console.WriteLine("Last digit is: three");
                    break;
                case 4:
                    Console.WriteLine("Last digit is: four");
                    break;
                case 5:
                    Console.WriteLine("Last digit is: five");
                    break;
                case 6:
                    Console.WriteLine("Last digit is: six");
                    break;
                case 7:
                    Console.WriteLine("Last digit is: seven");
                    break;
                case 8:
                    Console.WriteLine("Last digit is: eight");
                    break;
                case 9:
                    Console.WriteLine("Last digit is: nine");
                    break;
                default:
                    Console.WriteLine("It's OK!");
                    break;
            } Console.WriteLine();
        }

        public static int GetLastDigit(int num)
        {
            int digit;

            digit = num % 10;

            return digit;
        }
    }
}