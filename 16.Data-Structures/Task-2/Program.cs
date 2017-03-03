using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Add a number: ");
                int n = int.Parse(Console.ReadLine());
                stack.Push(n);
            } Console.WriteLine();

            Console.WriteLine("Numbers in opposite order:");
            Console.WriteLine();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}