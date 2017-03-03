using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * 5;
            }

            Console.WriteLine("Array items are:");
            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}