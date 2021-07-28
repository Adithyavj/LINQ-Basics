using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example.ListToDatatable
{
    public static class Pgrm4
    {
        //Reflection - ability to inspect an assembly's meta data at runtime
        public static void ListToDataTable()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ EmpId=101, Name="Adithya", Salary=45000},
                new Employee(){ EmpId=102, Name="Arjun", Salary=55000},
                new Employee(){ EmpId=103, Name="Athulya", Salary=30000}
            };

            DataTable dt = Convert(employees);

            var a = dt;

        }
        
        public static DataTable Convert<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public int Salary { get; set; }
    }
}
