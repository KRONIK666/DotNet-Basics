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
            Console.Write("Enter lenght of the square: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter height of the square: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int face = l * h;
            int perimeter = (l + h) * 2;

            Console.WriteLine("The face of the square is: " + face);
            Console.WriteLine("The perimeter of the square is: " + perimeter);
            Console.WriteLine();
        }
    }
}