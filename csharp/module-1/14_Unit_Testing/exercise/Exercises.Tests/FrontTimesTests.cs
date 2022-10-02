using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class FrontTimesTests
    {
        [TestMethod]
        public void GenerateStringTest()
        {
        FrontTimes frontTimes = new FrontTimes();

            string firstStringInput = "Chocolate";
            int firstIntInput = 2;

            string actualResult = frontTimes.GenerateString(firstStringInput, firstIntInput);

            string expectedResult = "ChoCho";

            CollectionAssert.Equals(expectedResult, actualResult);

            string secondStringInput = "Chocolate";
            int secondIntInput = 3;

            string actualSecondResult = frontTimes.GenerateString(secondStringInput, secondIntInput);

            string expectedSecondResult = "ChoChoCho";

            CollectionAssert.Equals(expectedSecondResult, actualSecondResult);

            string thirdStringInput = "Abc";
            int thirdIntInput = 3;

            string actualThirdResult = frontTimes.GenerateString(thirdStringInput, thirdIntInput);

            string expectedThirdResult = "ChoChoCho";

            CollectionAssert.Equals(expectedThirdResult, actualThirdResult);




        }



        
    }
}
    



