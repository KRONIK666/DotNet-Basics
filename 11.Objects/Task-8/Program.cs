using System;

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