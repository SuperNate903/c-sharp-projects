using System;

namespace NDateTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Write a number that will determine what the current time will be in that amount of hours.");
            Console.WriteLine(new DateTime
            (
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                DateTime.Now.Hour + Convert.ToInt32(Console.ReadLine()),
                DateTime.Now.Minute,
                DateTime.Now.Second
            ));
            Console.Read();
        }
    }
}
