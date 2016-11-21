using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Battery
    {
        private int hoursIdle;
        private int hoursTalk;
        private string batteryModel;

        public string BatteryModel
        {
            get { return batteryModel; }
            set { batteryModel = value; }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public enum BatteryType
        {
            LiIon, LiPolim, NiMH, NiCd
        }

        public Battery()
        {
            this.batteryModel = null;
            this.hoursIdle = 0;
            this.hoursTalk = 0;
        }

        public Battery(string batteryModel, int hoursIdle, int hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public void BatteryInfo()
        {
            Console.WriteLine("Battery information: battery model: {0}, idle hours: {1}, talk hours: {2}", batteryModel, hoursIdle, hoursTalk);
            Console.WriteLine();
        }
    }
}