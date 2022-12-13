using System;


namespace Methods_and_Objects
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee();
            sample.FirstName = "Sample";
            sample.LastName = "Student";
            sample.SayName();
            Console.ReadLine();

        }
    }
}
