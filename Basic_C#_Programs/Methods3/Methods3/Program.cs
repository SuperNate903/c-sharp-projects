using System;

namespace Methods3
{
    class Program
    {
        static void Main()
        {
            Methods method = new Methods();
            Console.WriteLine("Write a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write another number. Leave blank to use one number.");
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine(method.Multiply(number));
            }
            else
            {
                int number2 = Convert.ToInt32(input);
                Console.WriteLine(method.Multiply(number, number2));
            }
            Console.Read();
        }
    }
}
