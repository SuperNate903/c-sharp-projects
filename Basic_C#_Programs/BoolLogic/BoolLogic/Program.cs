using System;

namespace BoolLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            Console.WriteLine("Qualified?");
            bool qualified = Convert.ToInt32(age) > 15 & !Convert.ToBoolean(dui) & Convert.ToInt32(tickets) <= 3;
            Console.WriteLine(qualified);
            Console.Read();
        }
    }
}
