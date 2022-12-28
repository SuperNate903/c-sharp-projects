using System;

namespace Methods2
{
    class Program
    {
        static void Main()
        {
            Methods method = new Methods();
            Console.WriteLine("Input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(method.Operation(number));
            Console.WriteLine("Input a decimal");
            decimal decimalNum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Convert.ToInt32(method.Operation(decimalNum)));
            Console.WriteLine("Input a number (in string format)");
            string stringNum = Console.ReadLine();
            Console.WriteLine(method.Operation(stringNum));
            Console.Read();
        }
    }
}
