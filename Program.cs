using System;


namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");      //Prints The tech Academy and Student Daily Report on separate lines
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What Page Number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string trueFalse = Console.ReadLine();
            bool truFal = bool.Parse(trueFalse);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posiExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hourStudy = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
