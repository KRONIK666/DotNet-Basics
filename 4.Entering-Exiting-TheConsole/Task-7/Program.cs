using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int greatest;

            if (a > b)
            {
                greatest = a;
            }
            else
            {
                greatest = b;
            }

            if (greatest < c)
            {
                greatest = c;
            }

            if (greatest < d)
            {
                greatest = d;
            }

            if (greatest < e)
            {
                greatest = e;
            }

            Console.WriteLine("Greatest number is: " + greatest);
            Console.WriteLine();
        }
    }
}