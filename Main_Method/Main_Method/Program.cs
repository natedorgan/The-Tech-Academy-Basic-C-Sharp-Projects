using System;
using System.Collections.Generic;


namespace Main_Method
{
    class Program
    {
        static void Main()
        {
            var mathObject = new Math();
            var result = mathObject.Operator(4);
            var mathObject2 = new Math();
            var result2 = mathObject2.Operator(Convert.ToDecimal(4.4));
            var mathObject3 = new Math();
            var result3 = mathObject3.Operator("4");


            Console.WriteLine("4 + 2 = " + result);
            Console.WriteLine("4.4 * 2  = " + result2);
            Console.WriteLine("4 / 2 = " + result3);
            Console.ReadLine();
        }
    }
}
