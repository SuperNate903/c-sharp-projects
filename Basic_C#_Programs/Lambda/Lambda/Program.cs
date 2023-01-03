using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main()
        {
            List<Employee> EmpList = new List<Employee>()
            {
                new Employee() { Id = 3, FirstName = "Joe", LastName = "Davis" },
                new Employee() { Id = 16, FirstName = "Bob", LastName = "Smith" },
                new Employee() { Id = 4, FirstName = "Jonas", LastName = "Lam" },
                new Employee() { Id = 21, FirstName = "Luke", LastName = "Douglas" },
                new Employee() { Id = 6, FirstName = "Adam", LastName = "Smith" },
                new Employee() { Id = 31, FirstName = "Joe", LastName = "Hurley" },
                new Employee() { Id = 25, FirstName = "Greg", LastName = "Williams" },
                new Employee() { Id = 1, FirstName = "Ethan", LastName = "Ashley" },
                new Employee() { Id = 19, FirstName = "Susan", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Rose", LastName = "Roy" }
            };

            foreach(Employee emp in EmpList)
            {
                if(emp.FirstName == "Joe")
                {
                    Console.WriteLine("Id: " + emp.Id + " | Name: " + emp.FirstName + " " + emp.LastName);
                }
            }
            Console.WriteLine("");

            List<Employee> EmpNameList = EmpList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee emp in EmpNameList)
            {
                Console.WriteLine("Id: " + emp.Id + " | Name: " + emp.FirstName + " " + emp.LastName);
            }
            Console.WriteLine("");

            List<Employee> EmpIdList = EmpList.Where(x => x.Id > 5).ToList();
            foreach (Employee emp in EmpIdList)
            {
                Console.WriteLine("Id: " + emp.Id + " | Name: " + emp.FirstName + " " + emp.LastName);
            }

            Console.Read();
        }
    }
}
