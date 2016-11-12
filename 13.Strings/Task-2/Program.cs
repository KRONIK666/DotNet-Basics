using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int open = 0;
            int close = 0;
            string brackets = "((a + b) - 3 (12 * 3)) = (18 / 2)";

            foreach (char c in brackets)
            {
                if (c == '(' && open >= close)
                {
                    open++;
                }
                else if (c == ')' && open > close)
                {
                    close++;
                }
                else if (c == ')' && open <= close)
                {
                    close--;
                }
            }

            if (open == close)
            {
                Console.WriteLine("The brackets in the equation are put correctly.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The brackets in the equation are not put correctly.");
                Console.WriteLine();
            }
        }
    }
}