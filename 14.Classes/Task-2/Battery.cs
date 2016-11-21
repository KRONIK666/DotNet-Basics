using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Battery
    {
        private string batteryModel;
        private int idleTime;
        private int hoursTalk;
        private BatteryType battery;

        public enum BatteryType
        {
            LiIon, LiPolim, NiMH, NiCd
        }

        public Battery()
        {
            this.batteryModel = null;
            this.idleTime = 0;
            this.hoursTalk = 0;
            this.battery = BatteryType.LiIon;
        }

        public Battery(string batteryModel, int idleTime, int hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.idleTime = idleTime;
            this.hoursTalk = hoursTalk;
        }

        public void BatteryInfo()
        {
            Console.WriteLine("Battery information: " + battery);
            Console.WriteLine();
        }
    }
}