using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number to convert to hexadecimal: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("{0} to hexadecimal is {1}", num, num.ToString("X"));
            Console.WriteLine();
        }
    }
}