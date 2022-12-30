using System;

namespace ClassMethods
{
    class Program
    {
        static void Main()
        {
            int total = 0;
            Console.WriteLine("Write a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Methods.Divide(number, out total);
            Console.WriteLine(total);
            Console.WriteLine("Write another number");
            string stringNumber = Console.ReadLine();
            Methods.Divide(stringNumber, out total);
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
