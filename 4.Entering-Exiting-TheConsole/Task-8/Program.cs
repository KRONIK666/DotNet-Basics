using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = n;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                sum = sum + num;
                Console.WriteLine("Current sum is: " + sum);
            } Console.WriteLine();
        }
    }
}