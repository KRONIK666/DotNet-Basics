using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = 0;
            int tempSum = 0;
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                tempSum = myArray[i];

                for (int j = i + 1; j < n; j++)
                {
                    tempSum += myArray[j];

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                    }
                }
            }

            Console.WriteLine("Biggest sum is {0}", sum);
            Console.WriteLine();
        }
    }
}