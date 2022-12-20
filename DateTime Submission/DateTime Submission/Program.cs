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
            Console.WriteLine(DateTime.Now);
            DateTime currentTime = DateTime.Now; 
            Console.WriteLine("Please enter a number");
            DateTime userNum = DateTime.ParseExact(Console.ReadLine(), "HH", null);
            Console.WriteLine(userNum + currentTime);
        }
    }
}
