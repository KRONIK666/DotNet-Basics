using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 6, 5, 3, 3, 3, 1, 1, 0, 5, 5, 5, 5, 0 };
            int length = 1;
            int longestLength = 0;
            int elements = 0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] == myArray[i + 1])
                {
                    length++;

                }
                if (myArray[i] != myArray[i + 1])
                {
                    length = 1;
                }
                if (length > longestLength)
                {
                    longestLength = length;
                    elements = myArray[i];
                }
            }

            Console.Write("The longest sequence is by {0} elements. The elements are: ", longestLength);

            for (int i = 0; i < longestLength; i++)
            {
                Console.Write(elements + " ");
            } Console.WriteLine();

            Console.WriteLine();
        }
    }
}