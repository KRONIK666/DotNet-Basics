using System;

namespace Task_2
{
    public class GSM
    {
        private static string nokiaN95 = "Nokia 95";

        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;

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

        public GSM()
        {

        }

        public GSM(string model, string manufacturer, int price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, int price, string owner, string batteryModel, int idleTime, int hoursTalk, int size, int colors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery(batteryModel, idleTime, hoursTalk);
            this.display = new Display(size, colors);
        }

        public static void PhoneModel(string model)
        {
            model = nokiaN95;

            Console.WriteLine("The cheapest phone model is: " + model);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format("GSM information - model: {0}, manufacturer: {1}, price: {2}, owner: {3}, battery: {4}, display: {5}", model, manufacturer, price, owner, battery, display);
        }

        public void PrintInfo()
        {
            Console.WriteLine("GSM basic information - model: {0}, manufacturer: {1}, price: {2}, owner: {3}", model, manufacturer, price, owner);
            Console.WriteLine();
        }
    }
}