using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter an element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            Console.Write("Enter number to search in array: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            PrintResult(number, TimesMet(myArray, number));
        }

        public static int TimesMet(int[] myArray, int number)
        {
            int counter = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == number)
                {
                    counter++;
                }
            } return counter;
        }

        public static void PrintResult(int number, int counter)
        {
            Console.WriteLine("The number {0} is met {1} times in the array.", number, counter);
            Console.WriteLine();
        }
    }
}