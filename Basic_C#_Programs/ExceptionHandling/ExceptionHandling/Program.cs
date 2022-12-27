using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] numberArray = new int[] { 5,2,7,4,3 };
                Console.WriteLine("Input a number.");
                int number = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < numberArray.Length; i++)
                {
                    Console.WriteLine("Dividing " + numberArray[i] + " by " + number + " equals " + (Convert.ToDouble(numberArray[i]) / Convert.ToDouble(number)));
                }
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
