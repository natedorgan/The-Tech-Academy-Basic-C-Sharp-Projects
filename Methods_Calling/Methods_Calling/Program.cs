using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Calling
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter input:");
            var userInput = Convert.ToInt32(Console.ReadLine());

            var class1Object = new Class1();
            var result = class1Object.Add(userInput, 4);
            result = class1Object.Subtract(result, 2);
            result = class1Object.Divide(result, 1);

            Console.WriteLine(userInput + " + 4 " + " - 2 " + " / 1 = " + result);
            Console.ReadLine();
        }
    }
}
