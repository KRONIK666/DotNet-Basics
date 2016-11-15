using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 12;
            int h = 8;
            double area = ((double)(a + b)) / 2 * h;

            Console.WriteLine("The area of the trapezium is: " + area);
            Console.WriteLine();
        }
    }
}