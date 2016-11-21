using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Student
    {
        public static int studentsCount = 0;

        private string firstName;
        private string middleName;
        private string lastName;
        private int course;
        private string specialty;
        private string university;
        private string eMail;
        private string phoneNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Student()
        {
            studentsCount++;
        }

        public Student(string firstName, string middleName, string lastName, int course, string specialty, string university, string eMail, string phoneNumber)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;

            studentsCount++;
        }

        public Student(string firstName, string middleName, string lastName)
            : this(firstName, middleName, lastName, 0, null, null, null, null)
        {

        }

        public static int GetStudentCount()
        {
            return studentsCount;
        }

        public void StudentsInfo()
        {
            string name = firstName + " " + middleName + " " + lastName;

            if (course == 0 && specialty == null && university == null && eMail == null && phoneNumber == null)
            {
                Console.WriteLine("The student {0} haven't provided all educational information.", name);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The student {0} is in {1} course and studies {2} in {3}. The student can be contacted on the e-mail: {4} or on phone number: {5}", name, course, specialty, university, eMail, phoneNumber);
                Console.WriteLine();
            }
        }
    }
}