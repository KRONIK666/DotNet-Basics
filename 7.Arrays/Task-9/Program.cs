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
            Console.Write("Enter wanted sum: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = 0;
            int startNum = 0;
            int endNum = 0;
            bool sumFound = false;
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                sum = myArray[i];

                for (int j = i + 1; j < n; j++)
                {
                    sum = myArray[j] + sum;

                    if (sum == s)
                    {
                        startNum = i;
                        endNum = j;
                        sumFound = true;
                        break;
                    }
                }

                if (sumFound)
                {
                    break;
                }
            }

            Console.Write("Sum is found with elements: ");

            if (sumFound)
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    Console.Write(myArray[i] + " ");
                } Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No sum found.");
            } Console.WriteLine();
        }
    }
}