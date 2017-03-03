using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length N of first array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter length K of consecutive elements (K < N): ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = 0;
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            Array.Sort(myArray, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine("Biggest sum of consecutive elements is {0}", sum);
            Console.WriteLine();
        }
    }
}