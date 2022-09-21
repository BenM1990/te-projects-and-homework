using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> newDictionary = new Dictionary<string, bool>();
            
            Dictionary<string, int> newDictionary2 = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (newDictionary2.ContainsKey(word))
                {
                    newDictionary2[word]++;
                }
                else
                {
                    newDictionary2[word] = 1;
                }
            }
            foreach (KeyValuePair<string, int> pair in newDictionary2)
            {
                if (pair.Value > 1)
                    newDictionary[pair.Key] = true;
                else newDictionary[pair.Key] = false;
            }

            return newDictionary;
        }
    }
}
