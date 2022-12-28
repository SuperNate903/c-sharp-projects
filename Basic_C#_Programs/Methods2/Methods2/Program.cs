using System;

namespace Methods2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Methods.Operation(number));
            Console.WriteLine("Input a decimal");
            decimal decimalNum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Methods.Operation(decimalNum));
            Console.WriteLine("Input a number (in string format)");
            string stringNum = Console.ReadLine();
            Console.WriteLine(Methods.Operation(stringNum));
            Console.Read();
        }
    }
}
