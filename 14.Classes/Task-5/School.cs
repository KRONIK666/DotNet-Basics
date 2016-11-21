using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class School
    {
        List<SchoolClasses> classes;

        public School(SchoolClasses classes)
        {
            this.classes = new List<SchoolClasses>();
        }

        public void AddClass(SchoolClasses classToAdd)
        {
            this.classes.Add(classToAdd);
        }
    }
}