using System;

namespace Task_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size ot Matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);

                num += i;

                for (int j = 1; j < n; j++)
                {
                    num += n;
                    Console.Write("{0} ", num);
                }

                num = 0;
                Console.WriteLine();
            } Console.WriteLine();
        }
    }
}