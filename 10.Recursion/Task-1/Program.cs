using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[n];

            Loops(myArray, 0);
            Console.WriteLine();
        }

        static void Loops(int[] array, int index)
        {
            if (index >= array.Length)
            {
                foreach (int element in array)
                {
                    Console.Write("{0} ", element);
                } Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= array.Length; i++)
                {
                    array[index] = i;
                    Loops(array, index + 1);
                }
            }
        }
    }
}