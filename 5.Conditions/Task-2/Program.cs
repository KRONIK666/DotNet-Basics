using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: -");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: +");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: +");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: -");
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: +");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: -");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: -");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: +");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Result of multiplication of the numbers is: 0");
            } Console.WriteLine();
        }
    }
}