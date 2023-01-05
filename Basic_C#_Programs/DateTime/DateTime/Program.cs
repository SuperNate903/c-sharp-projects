using System;

namespace NDateTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Write a number that will determine what the current time will be in that amount of hours.");
            Console.WriteLine(DateTime.Now.AddHours(Convert.ToInt32(Console.ReadLine())));
            Console.Read();
        }
    }
}
