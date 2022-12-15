using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example1 = new Employee();
            Employee example2 = new Employee();

            example1.ID = 1;
            example2.ID = 2;

            if (example1 == example2)
            {
                Console.WriteLine(true);
            }
            Console.ReadLine();
            

        }
    }
}
