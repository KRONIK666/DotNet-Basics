using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius of the circle: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double perimeter = (2 * Math.PI * r);
            Console.WriteLine("The perimeter of the circle is: " + perimeter);
            Console.WriteLine();
        }
    }
}