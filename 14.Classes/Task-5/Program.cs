using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Teachers teacher = new Teachers("Ivan Lorisov");

            teacher.AddDiscipline(new Disciplines("Biology", 5, 5));
            teacher.AddDiscipline(new Disciplines("Chemistry", 3, 6));
            teacher.AddDiscipline(new Disciplines("Mathematics", 3, 8));

            SchoolClasses classB = new SchoolClasses("ID123");

            classB.AddStudent(new Students("Mitko Ivanov", 13));
            classB.AddStudent(new Students("Pavel Penkov", 20));
            classB.AddStudent(new Students("Ivaylo Tsvetkov", 25));
            classB.ClassesInfo("ID123");

            School school = new School(classB);

            school.AddClass(classB);
        }
    }
}