using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter quantity of phones to be added: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<GSM> phones = new List<GSM>();
            List<Battery> batteries = new List<Battery>();
            List<Display> displays = new List<Display>();

            string[] model = new string[n];
            string[] manufacturer = new string[n];
            int[] price = new int[n];
            string[] owner = new string[n];
            int[] hoursIdle = new int[n];
            int[] hoursTalk = new int[n];
            string[] batteryModel = new string[n];
            double[] displaySize = new double[n];
            int[] displayColors = new int[n];

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
                Console.Write("Enter battery model of the GSM: ");
                batteryModel[i] = Console.ReadLine();
                Console.Write("Enter idle hours of battery of the GSM: ");
                hoursIdle[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter talk hours of battery of the GSM: ");
                hoursTalk[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter display size of the GSM: ");
                displaySize[i] = double.Parse(Console.ReadLine());
                Console.Write("Enter display colors of the GSM: ");
                displayColors[i] = int.Parse(Console.ReadLine());
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

            for (int i = 0; i < n; i++)
            {
                Battery battery = new Battery(batteryModel[i], hoursIdle[i], hoursTalk[i]);

                battery.BatteryModel = batteryModel[i];
                battery.HoursIdle = hoursIdle[i];
                battery.HoursTalk = hoursTalk[i];
                batteries.Add(battery);
            }

            for (int i = 0; i < n; i++)
            {
                Display display = new Display(displaySize[i], displayColors[i]);

                display.DisplaySize = displaySize[i];
                display.DisplayColors = displayColors[i];
                displays.Add(display);
            }

            foreach (GSM phone in phones)
            {
                phone.PrintInfo();
            }

            foreach (Battery battery in batteries)
            {
                battery.BatteryInfo();
            }

            foreach (Display display in displays)
            {
                display.DisplayInfo();
            }
        }
    }
}