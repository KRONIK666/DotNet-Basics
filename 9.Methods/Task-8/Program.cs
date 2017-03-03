using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[length];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter an element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            Console.Write("Enter start index: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter end index: ");
            int endIndex = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The biggest number in the interval {0}-{1} is {2}.", startIndex, endIndex, GetMax(myArray, startIndex, endIndex));
            Console.WriteLine();
        }

        public static int GetMax(int[] array, int start, int end)
        {
            int maxNum = array[start];

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] > maxNum) maxNum = array[i];
            }

            return maxNum;
        }
    }
}