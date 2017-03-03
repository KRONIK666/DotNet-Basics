using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int max = GetMax(GetMax(a, b), c);

            Console.WriteLine("Biggest number is: " + max);
            Console.WriteLine();
        }

        public static int GetMax(int a, int b)
        {
            int bigger;

            if (a > b)
            {
                bigger = a;
            }
            else
            {
                bigger = b;
            }

            return bigger;
        }
    }
}