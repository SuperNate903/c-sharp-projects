using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee() { Id = 1, FirstName = "Bob", LastName = "Smith" };
            Employee emp2 = new Employee() { Id = 1, FirstName = "Susan", LastName = "Smith" };

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);
            Console.ReadLine();
        }
    }
}
