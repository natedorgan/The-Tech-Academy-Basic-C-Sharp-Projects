using System;


namespace Method_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            var userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to enter a second number? Answer yes or no");
            var Continue = Console.ReadLine();
            if (Continue == "yes")
            {
                Console.WriteLine("Enter a number:");
                var inputTwo = Convert.ToInt32(Console.ReadLine());
                var mathObject = new Class1();
                var result = mathObject.Method(userInput, inputTwo);
                Console.WriteLine(userInput + " + " + inputTwo + " = " + result);
                Console.ReadLine();
            }
            if (Continue == "no")
            {
                var mathObject2 = new Class1();
                var result2 = mathObject2.Method(userInput);
                Console.WriteLine(userInput + " + 1 = " + result2);
                Console.ReadLine();
            }

        }
    }
}
