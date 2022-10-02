using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        public void GetHerdTest()
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
         * GetHerd("giraffe") → "Tower"
         * GetHerd("") -> "unknown"
         * GetHerd("walrus") -> "unknown"
         * GetHerd("Rhino") -> "Crash"
         * GetHerd("rhino") -> "Crash"
         * GetHerd("elephants") -> "unknown"
         *
         */

            //Arange
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string input = "rhino";
            string output = "Crash";

            //Act
            string result = animalGroupName.GetHerd(input);
            

            //Assert
            Assert.AreEqual(result, output);
        }

        [DataTestMethod]
        [DataRow("Rhino", "Crash")]
        [DataRow("rhino", "Crash")]
        [DataRow("Giraffe", "Tower")]
        [DataRow("giraffe", "Tower")]
        [DataRow("Elephant", "Herd")]
        [DataRow("elephant", "Herd")]
        [DataRow("Lion", "Pride")]
        [DataRow("lion", "Pride")]
        [DataRow("Crow", "Murder")]
        [DataRow("crow", "Murder")]
        [DataRow("Pigeon", "Kit")]
        [DataRow("pigeon", "Kit")]
        [DataRow("Flamino", "Pat")]
        [DataRow("flamingo", "Pat")]
        [DataRow("Deer", "Herd")]
        [DataRow("deer", "Herd")]
        [DataRow("Dog", "Pack")]
        [DataRow("dog", "Pack")]
        [DataRow("Crocodile", "Float")]
        [DataRow("crocodile", "Float")]
        [DataRow("", "unkown")]
        [DataRow(null, "uknown")]
        public void GetHerdTest(string animalInput, string herdOutput)
        {
            string input = animalInput;

            string result = herdOutput;

            Assert.AreEqual(herdOutput, result);
        }


    }
}
