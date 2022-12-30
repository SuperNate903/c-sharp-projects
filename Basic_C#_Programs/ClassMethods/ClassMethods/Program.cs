using System;

namespace ClassMethods
{
    class Program
    {
        static void Main()
        {
            Methods method = new Methods();
            Console.WriteLine("Write a number");
            int number = Convert.ToInt32(Console.ReadLine());
            method.Divide(number, out int total);
            Console.WriteLine(total);
            Console.WriteLine("Write another number");
            string stringNumber = Console.ReadLine();
            method.Divide(stringNumber, out total);
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
