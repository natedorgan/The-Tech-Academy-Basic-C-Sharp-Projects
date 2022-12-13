using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathObject = new Class1();
            mathObject.Method(1, 2);
            var mathObject = new Class1();
            mathObject.Method(num1: 1, num2: 2);
            Console.ReadLine();
        }
    }
}
