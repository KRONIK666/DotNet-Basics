using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();

            for (int i = 1; i <= 10000; ++i)
            {
                primes.Add(i);
            }

            int prime = 2;
            int indexAt = 0;
            bool limitReached = false;

            while (!limitReached)
            {
                for (int i = 0; i < primes.Count; ++i)
                {
                    int valid = primes[i];

                    if (valid % prime == 0 && valid != prime)
                    {
                        primes[i] = 0;
                    }
                }

                do
                {
                    prime = primes[++indexAt];

                    if (indexAt >= primes.Count - 1)
                    {
                        limitReached = true;
                        break;
                    }
                } while (prime == 0);
            }

            PrintList(primes, false);
        }

        static void PrintList(List<int> nums, bool printZero = true)
        {
            Console.WriteLine("Prime numbers are:");
            Console.WriteLine();

            foreach (int n in nums)
            {
                if (!printZero && n == 0)
                {
                    continue;
                } Console.Write("{0}" + " ", n);
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}