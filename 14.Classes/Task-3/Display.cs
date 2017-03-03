using System;

namespace Task_3
{
    public class Display
    {
        private double displaySize;
        private int displayColors;

        public double DisplaySize
        {
            get { return displaySize; }
            set { displaySize = value; }
        }

        public int DisplayColors
        {
            get { return displayColors; }
            set { displayColors = value; }
        }

        public Display()
        {
            this.displaySize = 0.0;
            this.displayColors = 0;
        }

        public Display(double displaySize, int displayColors)
        {
            this.displaySize = displaySize;
            this.displayColors = displayColors;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Display information: display size: {0}, display colors: {1}", displaySize, displayColors);
            Console.WriteLine();
        }
    }
}