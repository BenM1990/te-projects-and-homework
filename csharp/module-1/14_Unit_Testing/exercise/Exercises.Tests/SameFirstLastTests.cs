using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class FirstLastTests
    {
        [TestMethod]
        public void IsItTheSameTest()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            {
                int[] firstIntArrayInput = {1, 2, 3};

                bool actualFirstResult = false;
                bool expectedFirstResult = false;

                Assert.AreEqual(expectedFirstResult, actualFirstResult);

                int[] secondIntArrayInput = { 6, 2, 4, 6 };

                bool actualSecondResult = true;
                bool expectedSecondResult = true;

                Assert.AreEqual(expectedSecondResult, actualSecondResult);



            }
        }
    }
}
