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
            Console.Write("Enter a sequence, separated with comas: ");

            List<int> sequence = new List<int>();
            string[] nums = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine();

            foreach (var item in nums)
            {
                sequence.Add(int.Parse(item));
            }

            int[] numberOfTimes = new int[1001];

            foreach (int item in sequence)
            {
                numberOfTimes[item]++;
            }

            for (int i = 0; i < numberOfTimes.Length; i++)
            {
                if (numberOfTimes[i] != 0)
                {
                    Console.WriteLine("{0} -> {1} times", i, numberOfTimes[i]);
                }
            } Console.WriteLine();
        }
    }
}