using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hexadecimal number to convert to binary: ");
            string num = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("{0} to binary is {1}", num, Convert.ToString(Convert.ToInt32(num, 16), 2));
            Console.WriteLine();
        }
    }
}