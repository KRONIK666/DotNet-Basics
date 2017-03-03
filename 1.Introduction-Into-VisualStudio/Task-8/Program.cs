using System;

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