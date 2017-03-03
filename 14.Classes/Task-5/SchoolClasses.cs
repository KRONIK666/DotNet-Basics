using System;
using System.Collections.Generic;

namespace Task_5
{
    public class SchoolClasses
    {
        private string uniqueTextID;

        List<Students> students;
        List<Teachers> teachers;

        public string UniqueTextID
        {
            get { return uniqueTextID; }
            set { uniqueTextID = value; }
        }

        public SchoolClasses(string id)
        {
            this.uniqueTextID = id;
            this.students = new List<Students>();
            this.teachers = new List<Teachers>();
        }

        public void AddStudent(Students student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Students student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teachers teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teachers teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void ClassesInfo(string id)
        {
            Console.WriteLine("The class is with unique text ID: {0}", uniqueTextID);
            Console.WriteLine();
        }
    }
}