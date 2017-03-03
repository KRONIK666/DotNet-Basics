using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            int weight = int.Parse(Console.ReadLine());

            double kilos = (double)weight * 0.17;
            Console.WriteLine("Your weight on the Moon is: " + kilos);
            Console.WriteLine();
        }
    }
}