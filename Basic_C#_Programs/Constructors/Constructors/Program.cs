using System;

namespace Constructors
{
    class Program
    {
        static void Main()
        {
            const int number = 27;
            var stringVar = "This is a string";

            Console.WriteLine(number);
            Console.WriteLine(stringVar);

            Console.WriteLine("We're going to add a number to 8. Write a number.");
            ChainConstruct constructor = new ChainConstruct(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
