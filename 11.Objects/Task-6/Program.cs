using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choice;

            do
            {
                Console.WriteLine("Calculate the area of a triangle by given:");
                Console.WriteLine();

                Console.WriteLine("1.Three sides of the triangle.");
                Console.WriteLine("2.Length of one side and it's altitude.");
                Console.WriteLine("3.Length of two sides and the angle between them.");
                Console.WriteLine("4.Exit!");
                Console.WriteLine();

                Console.Write("Enter choice from 1 to 4: ");
                choice = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        CalculateByThreeSides();
                        break;
                    case 2:
                        CalculateBySideAndAltitude();
                        break;
                    case 3:
                        CalculateByTwoSidesAndAngle();
                        break;
                }
            } while (choice != 4);
        }

        public static void CalculateByThreeSides()
        {
            Console.Write("Enter side a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine();

            float p = (a + b + c) / 2;

            Console.WriteLine("The area of the triangle is: {0}", (float)(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
            Console.WriteLine();
        }

        public static void CalculateBySideAndAltitude()
        {
            Console.Write("Enter side a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter altitude h: ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The area of the triangle is: {0}", (a * h) / 2);
            Console.WriteLine();
        }

        public static void CalculateByTwoSidesAndAngle()
        {
            Console.Write("Enter side a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter angle between sides: ");
            float angle = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The area of the triangle is: {0}", (a * b * Math.Sin(angle)) / 2);
            Console.WriteLine();
        }
    }
}