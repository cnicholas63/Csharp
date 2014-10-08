using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2
{
    class Program
    {
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;
        }
        // Notice that a reference to the struct is being passed in
        static void populateStruct(out student_data student, string fname, string surname, int id_number)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0f;
        }

        static void Main(string[] args)
        {
            student_data[] students = new student_data[4];

            populateStruct(out students[0], "Mark", "Anderson", 1);
            populateStruct(out students[1], "Jon", "Smith", 2);
            populateStruct(out students[2], "Tom", "Jones", 3);
            populateStruct(out students[3], "Ewan", "Evans", 4);

            printAllStudents(students);

            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        static void printAllStudents(student_data[] students)
        {
            foreach(student_data student in students ) {
                Console.WriteLine(student.forename + " " + student.surname);
                Console.WriteLine(student.surname);
                Console.WriteLine(student.id_number);
                Console.WriteLine(student.averageGrade);


            }


        }

    }
}
