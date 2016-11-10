using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            GetName(name);
        }

        public static void GetName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine();
        }
    }
}