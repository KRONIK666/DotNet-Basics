using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            age = age + 10;
            Console.WriteLine("Your age in 10 years: " + age);
            Console.WriteLine();
        }
    }
}