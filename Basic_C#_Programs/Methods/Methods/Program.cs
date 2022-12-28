using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write in a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            // This calls the Method1 method in the Methods class
            Console.WriteLine(Methods.Method1(input));
            // This calls the Method2 method in the Methods class
            Console.WriteLine(Methods.Method2(input));
            // This calls the Method3 method in the Methods class
            Console.WriteLine(Methods.Method3(input));
            //Methods obj1 = new Methods();
            //Console.WriteLine(obj1.Method4(input));
            Console.ReadLine();
        }
    }
}
