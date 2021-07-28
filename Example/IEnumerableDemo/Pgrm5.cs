using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.IEnumerableDemo
{
    public static class Pgrm5
    {

        public static void ToGroup()
        {
            //Using Method Syntax
            var GroupByMS = Students1.GetStudents().GroupBy(s => s.Branch);

            //It will iterate through each groups
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group
                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
                }
            }
        }
    }

    public class Students1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public static List<Students1> GetStudents()
        {
            return new List<Students1>()
        {
            new Students1 { ID = 1001, Name = "Preety", Gender = "Female",
                                         Branch = "CSE", Age = 20 },
            new Students1 { ID = 1002, Name = "Snurag", Gender = "Male",
                                         Branch = "ETC", Age = 21  },
            new Students1 { ID = 1003, Name = "Pranaya", Gender = "Male",
                                         Branch = "CSE", Age = 21  },
            new Students1 { ID = 1004, Name = "Anurag", Gender = "Male",
                                         Branch = "CSE", Age = 20  },
            new Students1 { ID = 1005, Name = "Hina", Gender = "Female",
                                         Branch = "ETC", Age = 20 },
            new Students1 { ID = 1006, Name = "Priyanka", Gender = "Female",
                                         Branch = "CSE", Age = 21 },
            new Students1 { ID = 1007, Name = "santosh", Gender = "Male",
                                         Branch = "CSE", Age = 22  },
            new Students1 { ID = 1008, Name = "Tina", Gender = "Female",
                                         Branch = "CSE", Age = 20  },
            new Students1 { ID = 1009, Name = "Celina", Gender = "Female",
                                         Branch = "ETC", Age = 22 },
            new Students1 { ID = 1010, Name = "Sambit", Gender = "Male",
                                         Branch = "ETC", Age = 21 }
        };
        }
    }
}
