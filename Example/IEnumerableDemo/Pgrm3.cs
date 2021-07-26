using Example.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.IEnumerableDemo
{
    public static class Pgrm3
    {
        public static void New()
        {
            StudentDBContext context = new StudentDBContext();
            IQueryable<Data.Student> students = context.Students
                                    .AsQueryable()
                                    .Where(x => x.Gender == "Male");
            students = students.Take(2);
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
