using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;

            Console.Write("Enter your gender, m/f: ");
            string gender = Console.ReadLine();

            if (gender == "m")
            {
                isMale = true;
            }
            else if (gender == "f")
            {
                isMale = false;
            }

            if (isMale == true)
            {
                Console.WriteLine("You gender is: Male");
                Console.WriteLine();
            }
            else if (isMale == false)
            {
                Console.WriteLine("You gender is: Female");
                Console.WriteLine();
            }
        }
    }
}