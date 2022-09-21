using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> newDictionary = new Dictionary<string, int>();


            for (int i = 0; i < words.Length; i++)
            {
                //if the dictionary already contains the key
                if (newDictionary.ContainsKey(words[i]))
                {
                    newDictionary[words[i]] ++;
                    // add 1 to the value
                    }
                else
                {
                //if the dictionary does NOT contain the key
                
                newDictionary[words[i]]=1;
                        
                // add the item to the dictionary
                // when we add a new item the key will be words[i]
                //when we add a new item the value will start at 1
                }
            }    

            return newDictionary;
        }
    }
}
