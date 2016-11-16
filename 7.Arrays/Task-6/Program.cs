using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int temp;
            int lowestIndex;
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            for (int j = 0; j < n - 1; j++)
            {
                lowestIndex = j;

                for (int i = j + 1; i < n; i++)
                {
                    if (myArray[i] < myArray[lowestIndex])
                    {
                        lowestIndex = i;
                    }
                }

                if (lowestIndex != j)
                {
                    temp = myArray[j];
                    myArray[j] = myArray[lowestIndex];
                    myArray[lowestIndex] = temp;
                }
            }

            Console.Write("The array with sorted elements: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", myArray[i]);
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}