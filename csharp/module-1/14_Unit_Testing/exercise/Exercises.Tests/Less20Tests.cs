using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class Less20Tests
    {
        [TestMethod]
        public void IsLessThanMulitpleOf20Test()
        {
            Less20 less20 = new Less20();
            {

                int input = 18; //true
                int secondInput = 19; //true
                int thirdInput = 20; //false

                bool actualResult = less20.IsLessThanMultipleOf20(input);
                bool actualResultTwo = less20.IsLessThanMultipleOf20(secondInput);
                bool actualResultThree = less20.IsLessThanMultipleOf20(thirdInput);

                bool expectedResult = true;
                bool expectedResultTwo = true;
                bool expectedResultThree = false;

                CollectionAssert.Equals(actualResult, expectedResult);
                CollectionAssert.Equals(actualResultTwo, expectedResultTwo);
                CollectionAssert.Equals(actualResultTwo, expectedResultThree);

                int fourthInput = -16; //false
                int fifthInput = 39; //true
                int sixthInput = 60; //false

                bool actualResultFour = less20.IsLessThanMultipleOf20(fourthInput);
                bool actualResultFive = less20.IsLessThanMultipleOf20(fifthInput);
                bool actualResultSix = less20.IsLessThanMultipleOf20(sixthInput);

                bool expectedResultFour = false;
                bool expectedResultFive = true;
                bool expectedResultSix = false;

                CollectionAssert.Equals(actualResultFour, expectedResultFour);
                CollectionAssert.Equals(actualResultFive, expectedResultFive);
                CollectionAssert.Equals(actualResultSix, expectedResultSix);


            }

        }
    }
}
