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
            Console.Write("Enter a side of the square triangle: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b side of the square triangle: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The hypotenuse c of the square triangle is: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine();
        }
    }
}