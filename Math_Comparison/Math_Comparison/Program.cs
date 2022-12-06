using System;


namespace Math_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your Hourly Rate?");
            string p1hourlyRate = Console.ReadLine();
            int p1hourRate = Convert.ToInt32(p1hourlyRate);
            Console.WriteLine("How many hours do you work per week?");
            string p1hoursWorked = Console.ReadLine();
            int p1hourWork = Convert.ToInt32(p1hoursWorked);
            int p1salTotal = p1hourWork * p1hourRate * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your Hourly Rate?");
            string p2hourlyRate = Console.ReadLine();
            int p2hourRate = Convert.ToInt32(p2hourlyRate);
            Console.WriteLine("How many hours do you work per week?");
            string p2hoursWorked = Console.ReadLine();
            int p2hourWork = Convert.ToInt32(p2hoursWorked);
            int p2salTotal = p2hourWork * p2hourRate * 52;
            Console.WriteLine("Annual salary of Person 1:" + p1salTotal);
            Console.WriteLine("Annual salary of Person 2:" + p2salTotal);
            bool greaterThan = p1salTotal > p2salTotal;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(greaterThan);
            Console.ReadLine();
        }
    }
}
