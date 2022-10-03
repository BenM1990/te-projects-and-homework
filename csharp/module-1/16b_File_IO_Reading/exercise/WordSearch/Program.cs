using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fileSystemPath = Console.ReadLine();


            //2. Ask the user for the search string

            Console.WriteLine("What is the search word you are looking for?");
            string word = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive? (Y/N)");
            string caseSensitive = Console.ReadLine();
            if (caseSensitive.ToUpper() == "N")
            {
                try
                {
                    int lineCount = 1;
                    using (StreamReader fileInput = new StreamReader(fileSystemPath))
                    {
                        while (!fileInput.EndOfStream)
                        {
                            string line = fileInput.ReadLine();
                            string lineUp = line.ToUpper();
                            string wordUpper = word.ToUpper();
                            

                            if (lineUp.Contains(wordUpper))
                            {
                                Console.WriteLine(lineCount + ") " + line);
                            }
                            lineCount++;

                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //3. Open the file



            else if(caseSensitive.ToUpper() == "Y")
            {
                try
                {
                    int lineCount = 0;
                    using (StreamReader fileInput = new StreamReader(fileSystemPath))
                    {
                        while (!fileInput.EndOfStream)
                        {
                            string line = fileInput.ReadLine();

                            lineCount++;

                            if (line.Contains(word))
                            {
                                Console.WriteLine(lineCount + ") " + line);
                            }
                            

                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error reading the file.");
                    Console.WriteLine(ex.Message);
                }
            }

            //Console.WriteLine("Your answer: {lineCount}");
            //Console.WriteLine("RIGHT!");
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}

