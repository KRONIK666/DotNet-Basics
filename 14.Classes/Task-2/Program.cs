using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter quantity of phones to be added: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<GSM> phones = new List<GSM>();

            string defaultModel = null;
            string[] model = new string[n];
            string[] manufacturer = new string[n];
            int[] price = new int[n];
            string[] owner = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter model of the GSM: ");
                model[i] = Console.ReadLine();
                Console.Write("Enter manufacturer of the GSM: ");
                manufacturer[i] = Console.ReadLine();
                Console.Write("Enter price of the GSM: ");
                price[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter owner of the GSM: ");
                owner[i] = Console.ReadLine();
            } Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                GSM gsm = new GSM(model[i], manufacturer[i], price[i], owner[i]);

                gsm.Model = model[i];
                gsm.Manufacturer = manufacturer[i];
                gsm.Price = price[i];
                gsm.Owner = owner[i];

                phones.Add(gsm);
            }

            GSM.PhoneModel(defaultModel);

            foreach (GSM phone in phones)
            {
                phone.PrintInfo();
            }
        }
    }
}