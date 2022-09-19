﻿using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            char firstCharacter = name[0];
            char lastCharacter = name[name.Length - 1]; //name[^]

            Console.WriteLine($"First and Last Character: {firstCharacter}, {lastCharacter}. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string firstThreeCharacters = name.Substring(0, 3); // start at zero, give me 1 2 3 characters

            Console.WriteLine($"First 3 characters: {firstThreeCharacters}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            string lastThreeCharacters = name.Substring(9, 3); // start at index 9, include that and the next two (3)
            
            Console.WriteLine($"First 3 and Last 3 characters: {firstThreeCharacters}{lastThreeCharacters}");

            // 4. What about the last word?
            // Output: Lovelace

            string[] namePieces = name.Split(' ');
            
            Console.WriteLine($"Last Word: {namePieces[1]}");

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            bool containsLove = name.Contains("Love");
            
            Console.WriteLine($"Contains \"Love\": {containsLove}"); // "escape character" - the \ signifies that the " is part of the string

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int laceIndex = name.IndexOf("lace");
            Console.WriteLine($"Index of \"lace\": {laceIndex}");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            int aCounter = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if(name[i] == 'a' || name[i] == 'A')
                {
                    aCounter++; //shorthand for adding one
                }
            }

            //int aCounterLowercase = 0;
            //for (int i =0; i < name.Length; i++)
            //{
            //    if (name.ToLower()[i] == 'a') // string to lowercase, then look at the character
            //    {
            //       aCounterLowercase++; // shorthand for adding one
            //    }
            // }
            //string.lowerName = name.ToLower(); - toLower/toUpper does return a string if you want to persist it

            Console.WriteLine($"Number of \"a's\": {aCounter}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            name = name.Replace("Ada", "Ada, Countess of Love"); //.Replace() has two parameters - the old value and the new value

            Console.WriteLine(name); // we saved the string returned by the replace method to the name variable

            //point name to the new string returned by .Replace()
            //takes string, a reference point, and points it to a new object in the heap

            // 9. Set name equal to null.

            name = null;

            // 10. If name is equal to null or "", print out "All Done".

            //an empty string is still a string, there's something in the heap

            //if(name == nul || name == "")
            if (String.IsNullOrEmpty(name))
                {
                Console.WriteLine("All done!");
                }
            Console.ReadLine();
        }
    }
}