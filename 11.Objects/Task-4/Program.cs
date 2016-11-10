using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticks = Environment.TickCount;

            Console.WriteLine("Days since last System Boot: " + ticks / 1000 / 60 / 60 / 24);
            Console.WriteLine("Hours since last System Boot: " + ticks / 1000 / 60 / 60);
            Console.WriteLine("Minutes since last System Boot: " + ticks / 1000 / 60);
            Console.WriteLine();
        }
    }
}