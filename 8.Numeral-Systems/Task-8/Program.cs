using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number to convert to hexadecimal: ");
            string num = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("{0} to hexadecimal is {1}", num, Convert.ToInt32(num, 2).ToString("X"));
            Console.WriteLine();
        }
    }
}