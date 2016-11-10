using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[k];

            GetCombinations(myArray, 0, 1, n);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void GetCombinations(int[] array, int index, int start, int end)
        {
            if (index >= array.Length)
            {
                Console.Write("(");

                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write("{0} ", array[i]);
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                } Console.Write(") ");
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    array[index] = i;
                    GetCombinations(array, index + 1, i, end);
                }
            }
        }
    }
}