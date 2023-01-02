using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee() { FirstName = "Bob", LastName = "Smith" };
            Employee emp2 = new Employee() { FirstName = "Bob", LastName = "Smith" }; // Susan

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);
            Console.ReadLine();
        }
    }
}
