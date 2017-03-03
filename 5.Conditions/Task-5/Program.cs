using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете цифра между 0 и 9: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (number)
            {
                case 0:
                    Console.WriteLine("Въведената цифра е: Нула");
                    break;
                case 1:
                    Console.WriteLine("Въведената цифра е: Еденица");
                    break;
                case 2:
                    Console.WriteLine("Въведената цифра е: Двойка");
                    break;
                case 3:
                    Console.WriteLine("Въведената цифра е: Тройка");
                    break;
                case 4:
                    Console.WriteLine("Въведената цифра е: Четворка");
                    break;
                case 5:
                    Console.WriteLine("Въведената цифра е: Петица");
                    break;
                case 6:
                    Console.WriteLine("Въведената цифра е: Шестица");
                    break;
                case 7:
                    Console.WriteLine("Въведената цифра е: Седмица");
                    break;
                case 8:
                    Console.WriteLine("Въведената цифра е: Осмица");
                    break;
                case 9:
                    Console.WriteLine("Въведената цифра е: Деветка");
                    break;
                default:
                    Console.WriteLine("Въведената цифра не е в интервала!");
                    break;
            } Console.WriteLine();
        }
    }
}