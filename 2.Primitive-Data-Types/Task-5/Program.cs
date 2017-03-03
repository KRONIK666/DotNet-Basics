using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            string d = (string)c;

            Console.WriteLine(d + "!");
            Console.WriteLine();
        }
    }
}