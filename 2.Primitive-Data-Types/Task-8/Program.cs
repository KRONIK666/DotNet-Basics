using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter employee's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee's family: ");
            string family = Console.ReadLine();
            Console.Write("Enter employee's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter employee's gender: ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Enter employee's unique number: ");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Employee's Information:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Employee: " + name + " " + family);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Unique number: " + number);
            Console.WriteLine();
        }
    }
}