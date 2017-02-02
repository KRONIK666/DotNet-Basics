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
            string number;
            List<int> numbers = new List<int>();

            Console.Write("Enter a number: ");

            while ((number = Console.ReadLine()) != "")
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(number);
                numbers.Add(num);
            } Console.WriteLine();

            numbers.Sort();

            Console.WriteLine("Numbers in ordered way:");
            Console.WriteLine();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}