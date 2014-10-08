using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Student
{
    class Program
    {
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public string programmeTitle;
            public string programmeCode;
            public float averageGrade;
        }
        // Notice that a reference to the struct is being passed in
        static void populateStruct(out student_data student, string fname, string surname, int id_number, string title, string code)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.programmeTitle = title;
            student.programmeCode = code;
            student.averageGrade = 0.0F;
        }

        static void Main(string[] args)
        {
            student_data student1, student2, student3;
            populateStruct(out student1, "Mark", "Anderson", 1, "Programming", "CIS1234");
            printStudent(student1);
            populateStruct(out student3, "Tom", "Jones", 3, "OOP", "CIS2345");
            printStudent(student3);

            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        static void printStudent(student_data student)
        {
            Console.WriteLine("Name: " + student.forename + " " + student.surname);
            Console.WriteLine("Id: " + student.id_number);
            Console.WriteLine("Programme Title: " + student.programmeTitle);
            Console.WriteLine("Programme Code: " + student.programmeCode);
            Console.WriteLine("Av grade: " + student.averageGrade + "\n"); // Display grade and leave a blank line after the record
        }
    }
}
