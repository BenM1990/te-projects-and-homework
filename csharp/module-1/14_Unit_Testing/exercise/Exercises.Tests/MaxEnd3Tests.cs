using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void MakeArrayTest()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            {
                int[] firstInput = { 1, 2, 3 };
                int[] actualResult = maxEnd3.MakeArray(firstInput);
                int[] expectedResult = { 3, 3, 3 };

                CollectionAssert.AreEqual(expectedResult, actualResult);

                int[] secondInput = { 2, 17, 8 };
                int[] actualSecondResult = maxEnd3.MakeArray(secondInput);
                int[] expectedSecondResult = { 8, 8, 8 };

                CollectionAssert.AreEqual(expectedSecondResult, actualSecondResult);

            }
        }
    }
}