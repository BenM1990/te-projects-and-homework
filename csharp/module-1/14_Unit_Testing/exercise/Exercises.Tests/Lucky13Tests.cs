using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class Lucky13Tests
    {
        [TestMethod]
        public void GetLuckyTest()
        {
            Lucky13 lucky13 = new Lucky13();
            {
                int[] firstInput = { 1, 2, 3 };

                bool actualResult = lucky13.GetLucky(firstInput);

                bool expectedResult = false;

                Assert.AreEqual(expectedResult, actualResult);

                int[] secondInput = { 8, 26, 99 };

                bool actualSecondResult = lucky13.GetLucky(secondInput);

                bool expectedSecondResult = true;

                Assert.AreEqual(expectedSecondResult, actualSecondResult);


            }

        }
    }
}
