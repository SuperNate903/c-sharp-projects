﻿using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            if(weight <= 50)
            {
                Console.WriteLine("Please enter the package width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());
                if(width + height + length <= 50)
                {
                    int total = (width * height * length * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total);
                    Console.WriteLine("Thank you!");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.Read();
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
        }
    }
}
