using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Disciplines
    {
        private string disciplineName;
        private int lessons;
        private int exercises;

        public string DisciplineName
        {
            get { return disciplineName; }
            set { disciplineName = value; }
        }

        public int Lessons
        {
            get { return lessons; }
            set { lessons = value; }
        }

        public int Exercises
        {
            get { return exercises; }
            set { exercises = value; }
        }

        public Disciplines(string name, int lessons, int exercises)
        {
            this.disciplineName = name;
            this.lessons = lessons;
            this.exercises = exercises;
        }

        public void DisciplinesInfo(string name, int lessons, int exercises)
        {
            Console.WriteLine("Discipline {0} has {1} lessons and {2} exercises.", disciplineName, lessons, exercises);
            Console.WriteLine();
        }
    }
}