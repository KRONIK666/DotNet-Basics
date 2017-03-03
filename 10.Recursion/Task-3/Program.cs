using System;

namespace Task_3
{
    class Program
    {
        static string[] wordsArray;

        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            wordsArray = new string[length];

            for (int i = 0; i < wordsArray.Length; i++)
            {
                Console.Write("Enter {0} word: ", i + 1);
                wordsArray[i] = Console.ReadLine();
            } Console.WriteLine();

            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[k];

            FindSubsets(myArray, 0, 0, length);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void FindSubsets(int[] array, int index, int start, int end)
        {
            if (index >= array.Length)
            {
                Console.Write("(");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0}", wordsArray[array[i]]);

                    if (i != array.Length - 1)
                    {
                        Console.Write(" ");
                    }
                } Console.Write(") ");
            }
            else
            {
                for (int i = start; i < end; i++)
                {
                    array[index] = i;
                    FindSubsets(array, index + 1, i + 1, end);
                }
            }
        }
    }
}