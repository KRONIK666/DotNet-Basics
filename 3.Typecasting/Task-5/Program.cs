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
            Console.Write("Enter length of the rectangle: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Enter height of the rectangle: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double area = l * h;
            double perimeter = (l + h) * 2;

            Console.WriteLine("The area of the rectangle is: " + area);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            Console.WriteLine();
        }
    }
}