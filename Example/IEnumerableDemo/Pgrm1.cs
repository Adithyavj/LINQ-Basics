using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.IEnumerableDemo
{
    public static class Pgrm1
    { 
        public static void TestingIEnumerable()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Gender = "Male"},
                new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            //  select all males
            IEnumerable<Student> QuerySyntax = from std in students
                                               where std.Gender == "Male"
                                               select std;
            foreach (var s in QuerySyntax)
            {
                Console.Write($"Student: {s.Name}, Gender: {s.Gender} ");
            }
        }

        public static void TestingIQueryable()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Gender = "Male"},
                new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            //  select all males
            // AsQueryable - converts IEnumberable to IQueryable
            IQueryable<Student> MethodSyntax = students.AsQueryable().Where(std => std.Gender == "Male");
            foreach (var s in MethodSyntax)
            {
                Console.Write($"Student: {s.Name}, Gender: {s.Gender} ");
            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
