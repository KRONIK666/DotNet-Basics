using System;
using System.Collections.Generic;

namespace Task_5
{
    public class Teachers
    {
        List<Disciplines> disciplinesTeached;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Teachers(string name)
        {
            this.name = name;
            this.disciplinesTeached = new List<Disciplines>();
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplinesTeached.Add(discipline);
        }

        public void TeachersInfo(string name, Disciplines discipline)
        {
            Console.WriteLine("Teacher {0} teaches {1}.", name, disciplinesTeached);
            Console.WriteLine();
        }
    }
}