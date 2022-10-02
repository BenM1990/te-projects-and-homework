using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class StringBitsTests
    {
        [TestMethod]
        public void GetBitsTest()
        {
            StringBits stringBits = new StringBits();
            {
                string firstInput = "Hello";

                string actualFirstResult = stringBits.GetBits(firstInput);

                string expectedFirstResult = "Hlo";

                CollectionAssert.Equals(expectedFirstResult, actualFirstResult);

                string secondInput = "Cleveland";

                string actualSecondResult = stringBits.GetBits(secondInput);

                string expectedSecondResult = "Ceead";

                CollectionAssert.Equals(expectedSecondResult, actualSecondResult);

                string thirdInput = "";

                string actualThirdResult = stringBits.GetBits(thirdInput);

                string expectedThirdResult = null;

                CollectionAssert.Equals(expectedThirdResult, actualThirdResult);
            }
        }
    }
}
