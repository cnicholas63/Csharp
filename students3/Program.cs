using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students3
{
    class Program
    {
        public struct module_data
        {
            public string module_code;
            public string module_title;
            public int module_score;
        }

        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;
            public module_data[] modules; // = new module_data[6];

        }
        // Notice that a reference to the struct is being passed in
        static void populateStruct(out student_data student, string fname, string surname, int id_number,  module_data[] modules_list)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0f;
            student.modules = modules_list;
        }

        static void populateModules(out module_data module, string code, string title, int score)
        {
            module.module_code = code;
            module.module_title = title;
            module.module_score = score;
        }

        static void Main(string[] args)
        {
            var rand = new Random();
            student_data[] students = new student_data[4];
            module_data[] modules = new module_data[6];
            string[] codes = {"CIS001", "CIS002", "CIS003", "CIS004", "CIS004", "CIS005", "CIS006"};
            string[] titles = {"Programing Languages", "OOP", "Database Design", "Team Project", "Foo", "Bar"};


            for (int t = 0; t < modules.Length; t++)
            {
                populateModules(out modules[t], codes[t], titles[t], rand.Next(0, 100));
            }



            populateStruct(out students[0], "Mark", "Anderson", 1, modules);
            populateStruct(out students[1], "fred", "smith", 1, modules);
            populateStruct(out students[2], "mary", "brown", 1, modules);
            populateStruct(out students[3], "joan", "green", 1, modules);
            populateStruct(out students[4], "john", "orange", 1, modules);
            populateStruct(out students[5], "Frederikson", "blue", 1, modules);


            printAllStudents(students);

            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        static void printAllStudents(student_data[] students)
        {
            foreach(student_data student in students ) {
                Console.WriteLine(student.forename + " " + student.surname);
                Console.WriteLine(student.id_number);
                Console.WriteLine(student.averageGrade);

                foreach (module_data md in student.modules)
                {
                    Console.WriteLine(md.module_code + " " + md.module_title + " " + md.module_score);

                }


            }


        }

    }
}
