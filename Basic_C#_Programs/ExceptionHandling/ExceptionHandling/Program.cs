using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Input a number.");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input a second number.");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing " + firstNumber + " by " + secondNumber + " equals " + (firstNumber / secondNumber));
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid input. Please type a whole number.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
