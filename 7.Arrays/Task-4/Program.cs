using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 6, 2, 3, 4, 3, 0, 1, 2, 3, 5, 5, 5, 0 };
            int firstElement = 0;
            int lastElement = 0;
            int length = 1;
            int longestLength = 0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i + 1] - myArray[i] == 1)
                {
                    length++;
                }

                if (myArray[i] >= myArray[i + 1])
                {
                    length = 1;
                }

                if (length > longestLength)
                {
                    longestLength = length;
                    lastElement = i + 1;
                    firstElement = lastElement - longestLength + 1;
                }
            }

            Console.Write("The longest sequence is by {0} elements. The elements are: ", longestLength);

            for (int i = firstElement; i < longestLength + firstElement; i++)
            {
                Console.Write(myArray[i] + " ");
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}