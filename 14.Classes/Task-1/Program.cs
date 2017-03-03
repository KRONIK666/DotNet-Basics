using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivaylo", "Sashev", "Tsvetkov");
            Student student2 = new Student("Pavel", "Gabrielov", "Penkov", 3, "Law", "Sofia University", "pavel@abv.bg", "0898335566");

            int course;
            string firstName, middleName, lastName, specialty, university, eMail, phoneNumber;

            Console.Write("Enter fisrt name of the student: ");
            firstName = Console.ReadLine();
            Console.Write("Enter middle name of the student: ");
            middleName = Console.ReadLine();
            Console.Write("Enter last name of the student: ");
            lastName = Console.ReadLine();
            Console.Write("Enter specialty of the student: ");
            specialty = Console.ReadLine();
            Console.Write("Enter university of the student: ");
            university = Console.ReadLine();
            Console.Write("Enter eMail of the student: ");
            eMail = Console.ReadLine();
            Console.Write("Enter phone number of the student: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Enter course of the student: ");
            course = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Student student3 = new Student(firstName, middleName, lastName, course, specialty, university, eMail, phoneNumber);

            student1.StudentsInfo();
            student2.StudentsInfo();
            student3.StudentsInfo();

            Console.WriteLine("TOTAL STUDENTS: " + Student.GetStudentCount());
            Console.WriteLine();
        }
    }
}