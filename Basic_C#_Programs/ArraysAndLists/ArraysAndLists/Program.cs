using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            int index = 0;
            string[] stringArray = new string[] { "Apple", "Banana", "Pear" };
            do
            {
                Console.WriteLine("Choose a string:\n0. " + stringArray[0] + "\n1. " + stringArray[1] + "\n2. " + stringArray[2]);
                index = Convert.ToInt32(Console.ReadLine());
                if(index >= 0 & index <= 2)
                {
                    Console.WriteLine("You chose the string: " + stringArray[index] + ".");
                }
                else
                {
                    Console.WriteLine("That index does not exist.");
                }
            }
            while(index < 0 | index > 2);
            int[] integerArray = new int[] { 16, 12, 9 };
            do
            {
                Console.WriteLine("Choose an integer:\n0. " + integerArray[0] + "\n1. " + integerArray[1] + "\n2. " + integerArray[2]);
                index = Convert.ToInt32(Console.ReadLine());
                if (index >= 0 & index <= 2)
                {
                    Console.WriteLine("You chose the integer: " + integerArray[index] + ".");
                }
                else
                {
                    Console.WriteLine("That index does not exist.");
                }
            }
            while (index < 0 | index > 2);
            List<string> stringList = new List<string>();
            stringList.Add("Apricot");
            stringList.Add("Peach");
            stringList.Add("Squash");
            do
            {
                Console.WriteLine("Choose a string:\n0. " + stringList[0] + "\n1. " + stringList[1] + "\n2. " + stringArray[2]);
                index = Convert.ToInt32(Console.ReadLine());
                if (index >= 0 & index <= 2)
                {
                    Console.WriteLine("You chose the string: " + stringList[index] + ".");
                }
                else
                {
                    Console.WriteLine("That index does not exist.");
                }
            }
            while (index < 0 | index > 2);
            Console.Read();
        }
    }
}
