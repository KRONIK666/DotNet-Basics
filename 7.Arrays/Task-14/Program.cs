using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int subset = 0;
            int longestLength = 0;

            Console.Write("Enter array's length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            int n = (1 << length);
            int[,] subsets = new int[n, length];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    subsets[i, j] = i / (n / 2 / (1 << j)) % 2;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int max = -1000;
                int count = 0;

                for (int j = 0; j < length; j++)
                {
                    if (subsets[i, j] > 0)
                    {
                        if (myArray[j] >= max)
                        {
                            count++;
                            max = myArray[j];
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                }

                if (longestLength < count)
                {
                    longestLength = count;
                    subset = i;
                }
            }

            Console.Write("Result: ");

            for (int i = 0; i < length; i++)
            {
                if (subsets[subset, i] > 0)
                {
                    Console.Write(myArray[i] + " ");
                }
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}