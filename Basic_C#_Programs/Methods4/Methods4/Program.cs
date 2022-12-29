using System;

namespace Methods4
{
    class Program
    {
        static void Main()
        {
            Methods method = new Methods();
            Console.WriteLine("Write a number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write another number.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            method.Operation(number1, number2);
        }
    }
}
