using System;

namespace Task_3
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

            int greatest = 0;

            if (a > b)
            {
                greatest = a;
                Console.WriteLine("The greatest number is: " + a);

                if (a < c)
                {
                    greatest = c;
                    Console.WriteLine("The greatest number is: " + c);
                }
            }
            else if (b < c)
            {
                greatest = c;
                Console.WriteLine("The greatest number is: " + c);
            }
            else
            {
                greatest = b;
                Console.WriteLine("The greatest number is: " + b);
            } Console.WriteLine();
        }
    }
}