﻿using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateValue = new DateTime(2016, 11, 8);

            Console.WriteLine("Днес е {0}.", dateValue.ToString("dddd"));
            Console.WriteLine();
        }
    }
}