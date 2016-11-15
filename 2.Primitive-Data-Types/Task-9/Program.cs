using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Number a: " + a);
            Console.WriteLine("Number b: " + b);
            Console.WriteLine();
        }
    }
}