using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string with maximum length of 20 chars: ");
            string text = Console.ReadLine();
            Console.WriteLine();

            if (text.Length > 20)
            {
                Console.WriteLine("Your text is too long!");
                Console.WriteLine();
            }

            if (text.Length <= 20)
            {
                for (int i = text.Length; i < 20; i++)
                {
                    text = text + "*";
                }

                Console.WriteLine("Your string is: " + text);
                Console.WriteLine();
            }
        }
    }
}