using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string keyword = "in";

            Console.WriteLine("Original text: " + text);
            Console.WriteLine();

            int counter = 0;
            int index = 0;

            text.ToLower();

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(keyword, index + 1);
            }

            Console.WriteLine("Substring \"{0}\" is found {1} times in the original text.", keyword, counter);
            Console.WriteLine();
        }
    }
}