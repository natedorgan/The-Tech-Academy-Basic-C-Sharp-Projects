using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtn = DateTime.Now;
            Console.WriteLine("The time is: " + dtn);
            Console.WriteLine("Please enter a number of hours to add");
            int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime dtu = dtn.AddHours(userNum);
            Console.WriteLine("Updated time: " + dtu);
            Console.ReadLine();
        }
    }
}
