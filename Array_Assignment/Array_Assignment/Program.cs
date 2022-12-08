using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Hello", "This", "is", "an", "array"};

            int[] numArray = { 1, 2, 3, 4, 5 };

            List<string> stringList = new List<string>();
            stringList.Add("This");
            stringList.Add("is");
            stringList.Add("not");
            stringList.Add("an");
            stringList.Add("Array");


            //For selecting from stringArray

            Console.WriteLine("Pick an index of stringArray between 0 and 4");
            string Selection1 = Console.ReadLine();
            int Sel1 = Convert.ToInt32(Selection1);
            bool isComplete = false;
            do
            {
                switch (Sel1)
                {
                    case 0:
                        Console.WriteLine(stringArray[0]);
                        isComplete = true;
                        break;
                    case 1:
                        Console.WriteLine(stringArray[1]);
                        isComplete = true;
                        break;
                    case 2:
                        Console.WriteLine(stringArray[2]);
                        isComplete = true;
                        break;
                    case 3:
                        Console.WriteLine(stringArray[3]);
                        isComplete = true;
                        break;
                    case 4:
                        Console.WriteLine(stringArray[4]);
                        isComplete = true;
                        break;
                    default:
                        Console.WriteLine("Please select a number between 0 and 4");
                        Sel1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isComplete);

            //For selecting from numArray

            //Console.WriteLine("Pick an index of numArray between 0 and 4");
            //string Selection1 = Console.ReadLine();
            //int Sel1 = Convert.ToInt32(Selection1);
            //bool isComplete = false;
            //do
            //{
            //    switch (Sel1)
            //    {
            //        case 0:
            //            Console.WriteLine(numArray[0]);
            //            isComplete = true;
            //            break;
            //        case 1:
            //            Console.WriteLine(numArray[1]);
            //            isComplete = true;
            //            break;
            //        case 2:
            //            Console.WriteLine(numArray[2]);
            //            isComplete = true;
            //            break;
            //        case 3:
            //            Console.WriteLine(numArray[3]);
            //            isComplete = true;
            //            break;
            //        case 4:
            //            Console.WriteLine(numArray[4]);
            //            isComplete = true;
            //            break;
            //        default:
            //            Console.WriteLine("Please select a number between 0 and 4");
            //            Sel1 = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isComplete);

            //For selecting from stringList

            //Console.WriteLine("Pick an index of stringList between 0 and 4");
            //string Selection1 = Console.ReadLine();
            //int Sel1 = Convert.ToInt32(Selection1);
            //bool isComplete = false;
            //do
            //{
            //    switch (Sel1)
            //    {
            //        case 0:
            //            Console.WriteLine(stringList[0]);
            //            isComplete = true;
            //            break;
            //        case 1:
            //            Console.WriteLine(stringList[1]);
            //            isComplete = true;
            //            break;
            //        case 2:
            //            Console.WriteLine(stringList[2]);
            //            isComplete = true;
            //            break;
            //        case 3:
            //            Console.WriteLine(stringList[3]);
            //            isComplete = true;
            //            break;
            //        case 4:
            //            Console.WriteLine(stringList[4]);
            //            isComplete = true;
            //            break;
            //        default:
            //            Console.WriteLine("Please select a number between 0 and 4");
            //            Sel1 = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isComplete);

        }
    }
}
