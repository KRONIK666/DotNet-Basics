using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2016, 09, 05),
                new DateTime(2016, 09, 06),
                new DateTime(2016, 09, 22),
                new DateTime(2016, 09, 23),
            };

            DateTime[] workSaturdays = new DateTime[]
            {
                new DateTime(2016, 09, 10),
                new DateTime(2016, 09, 17),
            };

            int workingDays = 0;

            DateTime startDate = new DateTime(2016, 08, 31);
            DateTime endDate = new DateTime(2016, 10, 01);

            do
            {
                startDate = startDate.AddDays(1);

                if ((startDate.DayOfWeek >= DayOfWeek.Monday) && (startDate.DayOfWeek <= DayOfWeek.Friday))
                {
                    workingDays++;
                }

                foreach (var item in holidays)
                {
                    if (item.Date == startDate.Date)
                    {
                        workingDays--;
                    }
                }

                foreach (var item in workSaturdays)
                {
                    if (item.Date == startDate.Date)
                    {
                        workingDays++;
                    }
                }

            } while (startDate.Date != endDate.Date);

            Console.WriteLine("September has {0} working days.", workingDays);
            Console.WriteLine();
        }
    }
}