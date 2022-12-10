using System;
using System.Collections.Generic;


namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1

            string[] stringArray = { "this", "is", "a", "test" };
            Console.WriteLine("enter text to be appended to the items in the array");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)     //iterates through the array
            {
                stringArray[i] += userInput;                //appends userinput to each item in the array
            }
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);           //writes each item of the array in turn
            }
            Console.ReadLine();

            //Assignment 2

            //Infinite version - will count infinitely as there is no end condition. The count will increase by one infinitely as the condition will always be true.

            //int count = 0;

            //while(true)
            //{
            //    Console.WriteLine("Count = {0}.", count);
            //    count++;
            //}

            //Fixed version - added the if(count > 20) { break; } so that once the count will increase by one until hitting 20, at which point the program will end.
            //int count = 0;

            //while(true)
            //{
            //    Console.WriteLine("Count = {0}.", count);
            //    count++;

            //    if(count > 20)
            //    {
            //        break;
            //    }
            //}
            //Console.ReadLine();

            //Assignment 3

            //This loop works very similar to the one immediately preceding it but slightly condensed.

            int number = 0;

            while (number < 10)
            {
                Console.WriteLine("Number = {0}.", number);
                number++;

            }
            Console.ReadLine();

            //This loop incorporates the <= operator so will include the max count

            int arbitrary = 0;

            while (arbitrary <= 100)
            {
                Console.WriteLine("Number = {0}.", arbitrary);
                arbitrary += 10;

            }
            Console.ReadLine();

            //Assignment 4

            //This takes user input and iterates through the string. If a match is found, it prints the index of the match and if one is not found, an alert is given to the user.

            List<string> names = new List<string>() { "Bob", "Sue", "Dave", "Diana" };

            Console.WriteLine("Enter name to search");
            string userSearch = Console.ReadLine();

            foreach (string name in names)
            {
                if (name == userSearch)
                {
                    Console.WriteLine("Index: " + names.IndexOf(name));
                    break;
                }
                else
                {
                    Console.WriteLine("Result not found");
                    break;
                }
            }
            Console.ReadLine();

            //Assignment 5

            //This loops through the string to find the index or indiciesof the given user search within the list. 
            //It goes through each word and if there is a match, it outputs the loop count at which it was found

            List<string> nameCopies = new List<string>() { "Bob", "Sue", "Dave", "Diana", "Bob", "Mary", "Mary" };

            Console.WriteLine("Enter name to search");
            string userSearch = Console.ReadLine();
            int count = 0;

            foreach (string name in nameCopies)
            {
                if (name == userSearch)
                {
                    Console.WriteLine("Index: " + count);
                }
                count++;
            }
            if (!nameCopies.Contains(userSearch))
            {
                Console.WriteLine("Result not found");
            }
            Console.ReadLine();

            //Assignment 6

            //This loop iterates through the list and adds each element to a second list so that on the second check, a repeated item would be contained in that second list.


            List<string> letterList = new List<string>() { "A", "B", "C", "D", "C" };
            List<string> uniqueCheck = new List<string>();
            int count = 0;

            foreach (string letter in letterList)
            {
                if (!uniqueCheck.Contains(letter))
                {
                    Console.WriteLine(letter + " is unique.");
                    uniqueCheck.Add(item: letter);
                }
                else
                {
                    Console.WriteLine(letter + " is repeated.");
                }
                count++;
                
            }
            Console.ReadLine();
            
        }
    }
}
