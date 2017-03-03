using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert to binary: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("{0} to binary is {1}", num, Convert.ToString(num, 2));
            Console.WriteLine();
        }
    }
}