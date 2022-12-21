using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Program
    {
        public const string Title = "Example";
        static void Main(string[] args)
        {
            var arbitrary = 4;
            int answer = arbitrary + 4;
            Console.WriteLine(Title + " " + answer);
            Chain newChain = new Chain("Test");
            Console.WriteLine(newChain.Id);
            Console.ReadLine();

        }
    }
}
