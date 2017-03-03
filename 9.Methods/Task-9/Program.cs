using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choice;

            do
            {
                Console.WriteLine("1.Обърнете последователността на цифрите на едно число.");
                Console.WriteLine("2.Пресметнете средното аритметично на дадена поредица от числа.");
                Console.WriteLine("3.Решете линейното уравнение: a * x + b = 0.");
                Console.WriteLine();

                Console.Write("Въведете вашият избор: ");
                choice = byte.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        ReverseNumber();
                        break;
                    case 2:
                        Average();
                        break;
                    case 3:
                        SolveEquation();
                        break;
                }
            } while (choice != 3);

            Console.WriteLine(System.Environment.NewLine + "Край!");
            Console.WriteLine();
        }

        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);

            return new string(array);
        }

        public static void ReverseNumber()
        {
            int numberReverse;
            string stringNumberReverse;

            do
            {
                Console.Write("Въведете неотрицателно число: ");
                stringNumberReverse = Console.ReadLine();
                numberReverse = int.Parse(stringNumberReverse);
            } while (numberReverse < 0);

            Console.WriteLine();
            Console.WriteLine("Числото обърнато е: " + ReverseString(stringNumberReverse));
            Console.WriteLine();
        }

        public static void Average()
        {
            int numberAverage = 0;
            int entries = -1;
            int temp;
            bool input;
            string numberAverageString;

            do
            {
                Console.Write("Въведете поредица от числа. За приключване въведете буква: ");
                numberAverageString = Console.ReadLine();
                input = int.TryParse(numberAverageString, out temp);

                numberAverage += temp;
                entries++;
            } while (input);

            Console.WriteLine("Средното аритметично е {0}.", (float)numberAverage / entries);
            Console.WriteLine();
        }

        public static void SolveEquation()
        {
            int a = 0;

            do
            {
                Console.Write("Въведете a: ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("Въведете b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("x = {0}", (float)-b / a);
        }
    }
}