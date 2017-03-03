using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hexadecimal number to convert to decimal: ");
            string num = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("{0} to decimal is {1}", num, Convert.ToInt32(num, 16));
            Console.WriteLine();
        }
    }
}