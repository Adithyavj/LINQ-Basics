﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            QuerySyntax(integerList);
            MethodSyntax(integerList);
            MixedSyntax(integerList);
            Console.ReadLine();
        }

        private static void QuerySyntax(List<int> integerList)
        {
            // LINQ Query Syntax
            var result = from obj in integerList
                         where obj > 5
                         select obj;
            Console.WriteLine("Query Syntax: ");
            foreach (var item in result)
            {
                Console.WriteLine(item + " ");
            }
        }

        private static void MethodSyntax(List<int> integerList)
        {
            var result = integerList.Where(obj => obj > 5).ToList();
            Console.WriteLine("Method Syntax: ");
            foreach (var item in result)
            {
                Console.WriteLine(item + " ");
            }
        }

        // Filter list and calculate sum of values >5
        private static void MixedSyntax(List<int> integerList)
        {
            var result = (from obj in integerList
                          where obj > 5
                          select obj).Sum();

            Console.WriteLine("Mixed Syntax: ");
            Console.WriteLine("Sum is :" + result);
        }
    }
}
