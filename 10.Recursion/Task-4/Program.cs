using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }

            FindCombinations(myArray, 0);
            Console.WriteLine();
        }

        static void FindCombinations(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.Write("{");

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
                } Console.Write("} ");
            }
            else
            {
                for (int i = index; i < array.Length; i++)
                {
                    int temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                    FindCombinations(array, index + 1);
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                }
            }
        }
    }
}