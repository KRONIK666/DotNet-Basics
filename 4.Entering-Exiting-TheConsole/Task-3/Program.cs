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
            Console.Write("Company name: ");
            string company = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Office number: ");
            int officeNumber = int.Parse(Console.ReadLine());
            Console.Write("Fax number: ");
            int faxNumber = int.Parse(Console.ReadLine());
            Console.Write("Website: ");
            string website = Console.ReadLine();
            Console.Write("Manager's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager's telephone number: ");
            int telephoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(company);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Office number: " + officeNumber);
            Console.WriteLine("Fax number: " + faxNumber);
            Console.WriteLine("Website: " + website);
            Console.WriteLine("Manager: {0} {1}", firstName, lastName);
            Console.WriteLine("Manager's number: " + telephoneNumber);
            Console.WriteLine();
        }
    }
}