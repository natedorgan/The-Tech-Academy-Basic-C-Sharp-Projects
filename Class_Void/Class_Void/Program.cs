using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Void
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathObject = new Class1();
            Console.WriteLine("Please enter a number:");
            var userInput = Convert.ToInt32(Console.ReadLine());
            mathObject.Method(userInput);
            Console.ReadLine();
        }
    }
}
