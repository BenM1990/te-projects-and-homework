using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class NonStartTests
    {
        [TestMethod]
        public void GetPartialStringTest()
        {
            NonStart nonStart = new NonStart();
            {
                string firstInputStringA = "Hello";
                string firstInputStringB = "There";

                string actualFirstResult = nonStart.GetPartialString(firstInputStringA, firstInputStringB);

                string expectedFirstResult = "ellohere";

                CollectionAssert.Equals(expectedFirstResult, actualFirstResult);

                string secondInputStringA = "A";
                string secondInputStringB = "B";

                string actualSecondResult = nonStart.GetPartialString(secondInputStringA, secondInputStringB);

                string expectedSecondReulst = "";

                CollectionAssert.Equals(expectedSecondReulst, actualSecondResult);
            }
             
        }
    }
}
