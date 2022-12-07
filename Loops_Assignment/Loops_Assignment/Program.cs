using System;


namespace Loops_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 10;

            //This is a while loop that is able to function as a number guessing game but if the correct number (10) is guessed first then it does not function as intended (the program immediately ceases). This will be solved by making it a do while loop below.


            //while (!isGuessed)
            //{
            //    switch (number)
            //    {
            //        case 10:
            //            Console.WriteLine("You are correct!");
            //            isGuessed = true;
            //            break;
            //        case 11:
            //            Console.WriteLine("You guessed too high!");
            //            Console.WriteLine("Guess another!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 9:
            //            Console.WriteLine("You guessed too low!");
            //            Console.WriteLine("Guess another!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        default:
            //            Console.WriteLine("You are incorrect");
            //            Console.WriteLine("Guess another!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }
            //}

            //The do while loop ensures the loop will run at least once before hitting the while so that in the case that someone guesses correctly at first, it will display "You are correct!" before ending as intended. 
            
            do
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine("You are correct!");
                        isGuessed = true;
                        break;
                    case 11:
                        Console.WriteLine("You guessed too high!");
                        Console.WriteLine("Guess another!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed too low!");
                        Console.WriteLine("Guess another!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are incorrect");
                        Console.WriteLine("Guess another!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}
