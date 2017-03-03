using System;
using System.Collections.Generic;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st sequence number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Queue<int> sequence = new Queue<int>();

            sequence.Enqueue(n);

            for (int i = 1; i < 51; i++)
            {
                int temp = sequence.Peek();

                if (i % 3 == 1)
                {
                    sequence.Enqueue(temp + 1);
                }
                else if (i % 3 == 2)
                {
                    sequence.Enqueue(temp * 2 + 1);
                }
                else
                {
                    sequence.Enqueue(temp + 2);
                    Console.Write("{0} ", sequence.Dequeue());
                }
            }

            while (sequence.Count != 0)
            {
                Console.Write("{0} ", sequence.Dequeue());
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}