using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine();

            int number = 0;
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                number += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("The decimal is {0}", number);
            Console.WriteLine();
        }
    }
}