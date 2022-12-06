using System;


namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        { 
            Console.WriteLine("What is your age?");
            string inputAge = Console.ReadLine();
            int userAge = Convert.ToInt32(inputAge);
            Console.WriteLine("Have you ever had a DUI?");
            string inputDUI = Console.ReadLine();
            bool userDUI = bool.Parse(inputDUI); 
            Console.WriteLine("How many speeding tickets do you have?");
            string inputTickets = Console.ReadLine();
            int ticketNum = Convert.ToInt32(inputTickets);
            bool Qualified = (userAge>=15 && (userDUI==false) && ticketNum<=3);      //true if age >=15 DUI=false and <=3
            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualified);
            Console.ReadLine();
        }
    }
}
