using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            
            Console.WriteLine("What is the search word?");
            string searchWord = Console.ReadLine();

            Console.WriteLine("What is the replacement word?");
            string replacementWord = Console.ReadLine();

            Console.WriteLine("Where is the source file?");
            string sourceFile = Console.ReadLine();

            Console.WriteLine("Where is the desination file?");
            string destinationFile = Console.ReadLine();

            using (StreamReader sr = new StreamReader(sourceFile))
            {
                using(StreamWriter sw = new StreamWriter(destinationFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine().Replace(searchWord, replacementWord);
                            
                        sw.WriteLine(line);
                            
                    }
                }
            }
        }
    }
}
