using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Cat
    {
        private string name;
        private string color;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Cat()
        {
            this.name = "unnamed";
            this.color = "black";
        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void SayMeaw()
        {
            Console.WriteLine("Cat {0} said: Meaaaaaaaaaw!", name);
        }
    }
}