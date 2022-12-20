using System;

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            string p1HourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            string p1WeeklyHours = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            string p2HourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            string p2WeeklyHours = Console.ReadLine();
            int p1Salary = Convert.ToInt32(p1HourlyRate) * Convert.ToInt32(p1WeeklyHours) * 52;
            int p2Salary = Convert.ToInt32(p2HourlyRate) * Convert.ToInt32(p2WeeklyHours) * 52;
            Console.WriteLine("Annual salary of Person 1:\n"+p1Salary);
            Console.WriteLine("Annual salary of Person 2:\n" + p2Salary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool boolean = p1Salary > p2Salary;
            Console.WriteLine(boolean);
            Console.Read();
        }
    }
}
