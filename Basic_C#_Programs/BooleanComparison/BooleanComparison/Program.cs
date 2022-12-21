using System;

namespace BooleanComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write 3 numbers. These numbers will be multiplied together.");
            int product = 1;
            int numberAmount = 0;
            while (numberAmount < 3)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                product *= number;
                numberAmount++;
                if(numberAmount < 3)
                {
                    Console.WriteLine("The current product is " + product + ". " + (3 - numberAmount) + " more.");
                }
            }
            Console.WriteLine("The total product after your 3 inputs is " + product + ".");
            Console.WriteLine("I am thinking of a number between 1 and 10.");
            int guess = Convert.ToInt32(Console.ReadLine());
            bool correct = guess == 3;
            do
            {
                if(guess == 3)
                {
                    Console.WriteLine("Your number was: " + guess + ". That is correct!");
                    Console.Read();
                    break;
                }
                else if(guess > 10) {
                    Console.WriteLine("Your number was: " + guess + ". The number is not between 1 and 10.");
                }
                else
                {
                    Console.WriteLine("Your number was: " + guess + ". That is incorrect.");
                }
                Console.WriteLine("I am thinking of a number between 1 and 10.");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            while (!correct);
        }
    }
}
