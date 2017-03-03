using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of first array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter length of second array: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[m];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write("Enter element: ");
                arrayOne[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.Write("Enter element: ");
                arrayTwo[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            if (n == m)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Arrays are not equal!");
                        Console.WriteLine();
                        break;
                    }
                }

                Console.WriteLine("Arrays are equal!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Arrays are not equal!");
                Console.WriteLine();
            }
        }
    }
}