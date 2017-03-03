using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number to convert to decimal: ");
            string binary = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("{0} to decimal is {1}", binary, Convert.ToInt64(binary, 2));
            Console.WriteLine();
        }
    }
}