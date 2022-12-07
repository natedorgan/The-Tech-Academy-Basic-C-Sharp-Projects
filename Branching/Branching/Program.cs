using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the package's weight?");
            string packInput = Console.ReadLine();
            int packWeight = Convert.ToInt32(packInput);
            if(packWeight>50)
                {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                }
            else
                {
                Console.WriteLine("What is the package's width?");
                string widthInput = Console.ReadLine();
                int packWidth = Convert.ToInt32(widthInput);
                Console.WriteLine("What is the package's height?");
                string heightInput = Console.ReadLine();
                int packHeight = Convert.ToInt32(heightInput);
                Console.WriteLine("What is the package's length?");
                string lengthInput = Console.ReadLine();
                int packLength = Convert.ToInt32(lengthInput);
                int overallDimensions = (packLength + packHeight + packWidth);
                int dimTotal = overallDimensions * packWeight;
                decimal dimDec = Convert.ToDecimal(dimTotal);                //convert to decimal for cent values
                decimal shipCost = dimDec / 100;
                string endResult = overallDimensions > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for this package is: $" + shipCost;
                Console.WriteLine(endResult);
                Console.ReadLine();
                }
        }
    }
}
