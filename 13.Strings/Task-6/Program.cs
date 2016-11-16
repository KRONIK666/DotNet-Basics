using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string keyword = "submarine";

            string[] myArray = text.Split('.');

            Console.WriteLine("Those sentences contain the keyword \"submarine\":");
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Contains(keyword))
                {
                    Console.WriteLine(myArray[i].TrimStart() + ".");
                }
            } Console.WriteLine();
        }
    }
}