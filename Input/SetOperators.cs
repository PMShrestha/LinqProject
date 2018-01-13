﻿using LinqProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;

//Distinct,Except,Intersect,Union
namespace LinqProject.Input
{
    public class SetOperators
    {
        Employee employees = new Employee();
       
        //The Distinct extension method returns a new collection of unique elements from the given collection. 
        public void DistinctOperator()
        {
            var query = employees.GetAllEmployee().Select(e => e.FirstName).Distinct();
            Console.WriteLine("Distinct Employee Name List: ");
            foreach (var names in query)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        //The Except() method requires two collections. It returns a new collection with elements from the first collection which do not exist in the second collection (parameter collection). 
        public void ExceptOperator()
        {
            var employee1 = employees.GetAllEmployee().Select(e => e.FirstName);
            var employee2 = employees.GetAllEmployee2().Select(e => e.FirstName);

            var query = employee1.Except(employee2);
            Console.WriteLine("Using Except():Distinct Employee List from the First list, but not in the Second list are: ");
            foreach (var employeeList in query)
                Console.WriteLine(employeeList);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        //The Intersect extension method requires two collections. It returns a new collection that includes common elements that exists in both the collection.
        public void IntersectOperator()
        {
            var employee1 = employees.GetAllEmployee().Select(e => e.FirstName);
            var employee2 = employees.GetAllEmployee2().Select(e => e.FirstName);

            var query = employee1.Intersect(employee2);
            Console.WriteLine("Using Intersect():Common Distinct Employee Names that exists in both the collection: ");
            foreach (var employeeList in query)
                Console.WriteLine(employeeList);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        //The Union extension method requires two collections and returns a new collection that includes distinct elements from both the collections. 
        public void UnionOperator()
        {
           var employee1 = employees.GetAllEmployee().Select(e => e.FirstName);
            var employee2 = employees.GetAllEmployee2().Select(e => e.FirstName);

            var query = employee1.Union(employee2);
            Console.WriteLine("Using Union():All Distinct Employee Names that exists in both the collection: ");
            foreach (var employeeList in query)
                Console.WriteLine(employeeList);
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
