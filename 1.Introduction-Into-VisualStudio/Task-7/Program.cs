using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = -1;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    n = n + 2;
                    Console.WriteLine(n);
                }
                else if (i % 2 != 0)
                {
                    m = m - 2;
                    Console.WriteLine(m);
                }
            } Console.WriteLine();
        }
    }
}