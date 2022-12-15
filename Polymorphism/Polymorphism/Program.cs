using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable sample = new IQuittable();
            sample.Quit();
            Console.ReadLine();
        }
    }
}
