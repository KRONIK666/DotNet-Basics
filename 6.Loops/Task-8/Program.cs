using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of Matrix: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your Matrix is:");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < i + n + 1; j++)
                {
                    Console.Write("{0, 3}", j);
                } Console.WriteLine();
            } Console.WriteLine();
        }
    }
}