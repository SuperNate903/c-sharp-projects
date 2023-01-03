using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("What is the current day of the week?");
                Console.WriteLine("The day of the week is " + Enum.Parse(typeof(DotW), Console.ReadLine()) + ".");
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.Read();
        }
    }
    public enum DotW
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
