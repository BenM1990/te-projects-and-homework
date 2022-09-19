using System;

namespace IntroToObjectsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***********  Step 1: Use the *new* operator to create strings on the Heap  *************
            char[] helloChars = new char[] { 'h', 'e', 'l', 'l', 'o', '!' };
            string greeting = new string(helloChars);
            Console.WriteLine("Greeting: " + greeting);

            string salutation = new string("Welcome my friend");
            Console.WriteLine("Salutation: " + salutation);

            string toast = "May the compiler rise up to meet you.";
            Console.WriteLine("Toast: " + toast);


            // ***********  Step 2: Try out some string methods  *************

            Console.Write("Please type a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence);

            string uppercaseSentence = sentence.ToUpper();
            Console.WriteLine(uppercaseSentence);

            Console.WriteLine(sentence.ToLower());

            int firstSpace = sentence.IndexOf(" ");
            if (firstSpace == -1)
            {
                Console.WriteLine("The first word is " + sentence.Length + " characters long.");
            }
            else
            {
                Console.WriteLine("The first word is " + firstSpace + " characters long.");
            }

            Console.WriteLine(sentence.Replace("the", "the one and only"));

            string[] words = sentence.Split(" ");
            Console.WriteLine("The words in this sentence:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            string dashSentence = String.Join("-->", words);
            Console.WriteLine(dashSentence);

            Console.WriteLine(sentence);
        }
    }
}
