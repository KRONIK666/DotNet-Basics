using System;

namespace Task_5
{
    public class Students
    {
        private string name;
        private int uniqueNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int UniqueNumber
        {
            get { return uniqueNumber; }
            set { uniqueNumber = value; }
        }

        public Students(string name, int number)
        {
            this.name = name;
            this.uniqueNumber = number;
        }

        public void StudentsInfo(string name, int number)
        {
            Console.WriteLine("Student {0} is with unique number {1}.", name, uniqueNumber);
            Console.WriteLine();
        }
    }
}