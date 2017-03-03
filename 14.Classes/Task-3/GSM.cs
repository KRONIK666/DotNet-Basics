using System;
using System.Collections.Generic;

namespace Task_3
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call>();

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public Display Display
        {
            get { return display; }
            set { display = value; }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public GSM(string model, string manufacturer, int price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery();
            this.display = new Display();
        }

        public GSM(string model, string manufacturer, int price, string owner, string batteryModel, int hoursIdle, int hoursTalk, double displaySize, int displayColors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery(batteryModel, hoursIdle, hoursTalk);
            this.display = new Display(displaySize, displayColors);
        }

        public override string ToString()
        {
            return string.Format("GSM information - model: {0}, manufacturer: {1}, price: {2}, owner: {3}, battery: {4}, display: {5}", model, manufacturer, price, owner, battery, display);
        }

        public void PrintInfo()
        {
            Console.WriteLine("GSM information - model: {0}, manufacturer: {1}, price: {2}, owner: {3}", model, manufacturer, price, owner);
            Console.WriteLine();
        }

        public void AddCall(string date, string time, int duration)
        {
            callHistory.Add(new Call(date, time, duration));
        }

        public void DeleteCall(Call callToRemove)
        {
            callHistory.Remove(callToRemove);
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public string CalculateBill(double pricePerMinute)
        {
            double bill = 0;

            foreach (Call item in this.callHistory)
            {
                bill = bill + (item.Duration * pricePerMinute);
            } return String.Format("{0:0.00}", bill);
        }
    }
}