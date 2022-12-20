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
            Console.WriteLine("Please enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime date1 = DateTime.Now;
            string date1s = date1.ToString("%h");
            int date1i = Convert.ToInt32(date1s);
            int result = userNum + date1i;
            string results = result.ToString();
            DateTime resultdt = DateTime.Parse(results);
            Console.WriteLine(resultdt);
            Console.ReadLine();
        }
    }
}
