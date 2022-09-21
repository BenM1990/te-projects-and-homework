using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {

			/* Dictionary - A collection that stores objects
			 * Is not Ordered
			 * Store Data in KEY-VALUE pair
			 * Values are retrieved by using the KEY
			 * Values can have duplicates(synonym)
			 * Keys cannot have duplicates
			 * Keys need to be the same data type
			 * Values need to be the same data type
			 * 
			 */
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			//Declaring a Dictionary

			Dictionary<string, string> nameToZip = new Dictionary<string, string>();

			//Adding an item to a dictionary

			nameToZip["David"] = "44120";
			////Updates David since it already exists
			nameToZip["David"] = "44555";

			nameToZip["Tori"] = "44102";

			nameToZip["Ben"] = "44124";

            ///Retrieving VALUES from a diction

            Console.WriteLine("David lives in " + nameToZip["David"]);

			//Retrieve just the keys from Dictionary
			//IEnumerable<type> should match dictionary key type 
			IEnumerable<string> keys = nameToZip.Keys; /// returns a collection of all keys in the Dictionary

			foreach(string keyName in keys)
            {
				Console.WriteLine(keyName + " lives in " + nameToZip[keyName]);
            }

			//Checking if a Key is in a dictionary

			if(nameToZip.ContainsKey("David"))
			{
				Console.WriteLine("David Exists.");
            }
			Console.WriteLine();

			//Update David's zip code to be "12345"

			nameToZip["David"] = "12345";


			//Access Key Vaule pair from Dictionary

			foreach(KeyValuePair<string, string> nameZip in nameToZip)
            {
                Console.WriteLine(nameZip.Key + " liveth in " + nameZip.Value);
            }

			nameToZip.Remove("David");

            Console.WriteLine("Removed David");
            Console.WriteLine();

			foreach(KeyValuePair<string, string> nameZip in nameToZip)
            {
                Console.WriteLine($"Key:{nameZip.Key}, Value:{nameZip.Value}");
            }

			//IEnumerable<string> values = nameToZip.Values;


			///Initialize a dictionary - using the initializer

			Dictionary<string, string> studentNames = new Dictionary<string, string>()
			{
				{"Tracy", "Barry" },
				{"Colin", "Detwiller" },
				{"Kim", "Barry" },
				{ "Maria G", "Garcia" },
				{ "Amy", "Drupac" },
				{ "Ben", "Measor" },
				{ "Joe", "Gibson" },
				{ "Alex", "Hewson" }
			};

			///DEBUGGING////
			
			if(nameToZip.Count < 3)
            {
                Console.WriteLine("name to zip dictionary is small");
            }
			else
            {
                Console.WriteLine("name to zip dictionary is not small...");
            }
			
			foreach(KeyValuePair<string, string> student in studentNames)
            {
                Console.WriteLine("Key: " + student.Key);
                Console.WriteLine("Value: " + student.Value);
            }


		}
	}
}
