using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int counter = 0;
            int tempCounter = 1;
            int foundNumber = 0;
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            Array.Sort(myArray);

            for (int i = 0; i < n - 1; i++)
            {
                if (myArray[i] == myArray[i + 1])
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;
                }

                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = myArray[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", foundNumber, counter);
            Console.WriteLine();
        }
    }
}