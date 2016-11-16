using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of Fibonacci: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            ulong a = 0;
            ulong b = 1;
            ulong next;
            ulong sum = 0;

            for (int i = 0; i < n; i++)
            {
                next = a + b;
                b = a;
                a = next;
                sum = sum + next;
            }
            
            Console.WriteLine("Sum of Fibonacci's row: " + sum);
            Console.WriteLine();
        }
    }
}