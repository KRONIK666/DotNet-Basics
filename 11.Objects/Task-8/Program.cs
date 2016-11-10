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
            for (int i = 0; i < 10; i++)
            {
                Cat cat = new Cat("Cat" + Sequence.NextValue());
                cat.SayMeaw();
            } Console.WriteLine();
        }
    }
}