using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
            Console.WriteLine("Please enter the current day of the week");
            string userDay = Console.ReadLine();

                DaysoftheWeek week1;

                if (Enum.TryParse<DaysoftheWeek>(userDay, out week1))
                {
                   Console.WriteLine("{0} converted to {1}", userDay, week1);
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }

            }
            catch 
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }

        }
           public enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,  
        }
    }
}
