using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "Herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalNames = new Dictionary<string, string>()
            {
                { "Rhino", "Crash" },
                { "Giraffe", "Tower" },
                { "Elephant", "Herd"},
                { "Lion", "Pride" },
                {  "Crow", "Murder" },
                { "Pigeon", "Kit" },
                { "Flamingo", "Pat" },
                { "Deer", "Herd" },
                { "Dog", "Pack" },
                { "Crocodile", "Float" }
            };
            
            IEnumerable<string> groupName = animalNames.Keys;

            if(animalName == "" || animalName == null)
            {
                return "unknown";
            }

            foreach(string animal in groupName) 
            {
                if(animalName.ToUpper() == animal.ToUpper())
                {
                    return animalNames[animal];
                }
            }

            
                return "unknown";
            



        }
    }
}
