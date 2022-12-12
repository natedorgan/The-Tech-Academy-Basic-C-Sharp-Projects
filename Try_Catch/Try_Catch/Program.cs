using System;
using System.Collections.Generic;


namespace Try_Catch
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };
                Console.WriteLine("Pick a number to divide the list by");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int number in intList)
                {
                    Console.WriteLine(number + " divided by " + userInput + " is: ");
                    Console.WriteLine(number / userInput);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Continuing Loop");
        }
    }
}
