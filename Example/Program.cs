using System;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            QuerySyntax();
            Console.ReadLine();
        }

        private static void QuerySyntax()
        {
            // Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            // LINQ Query Syntax
            var result = from obj in integerList
                         where obj > 5
                         select obj;

            foreach (var item in result)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
