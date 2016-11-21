using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Display
    {
        private int size;
        private int colors;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Colors
        {
            get { return colors; }
            set { colors = value; }
        }

        public Display()
        {
            this.size = 0;
            this.colors = 0;
        }

        public Display(int size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }
}