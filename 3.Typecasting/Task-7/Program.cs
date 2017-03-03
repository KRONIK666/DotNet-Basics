using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (((x * x) + (y * y)) <= 5)
            {
                Console.WriteLine("The dot O is in the circle!");
            }
            else
            {
                Console.WriteLine("The dot O is not in the circle!");
            } Console.WriteLine();
        }
    }
}