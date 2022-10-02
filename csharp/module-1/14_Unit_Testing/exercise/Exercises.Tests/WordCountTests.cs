using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class WordCountTests
    {
        [TestMethod]
        public void GetCountTest()
        {
            WordCount wordCount = new WordCount();

            string[] firstInput = { "ba", "ba", "black", "sheep" };

            Dictionary<string, int> expectedResult = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };

            Dictionary<string, int> finalResult = wordCount.GetCount(firstInput);


            CollectionAssert.AreEqual(expectedResult, finalResult);


            ///Second test

            string[] secondInput = { "done", "with", "homework" };

            Dictionary<string, int> expectedSecondResult = new Dictionary<string, int>()
            {
                {"done", 1 },
                {"with", 1 },
                {"homework", 1 }
            };

            Dictionary<string, int> finalSecondResult = wordCount.GetCount(secondInput);


            CollectionAssert.AreEqual(expectedSecondResult, finalSecondResult);

        }

    }
}
    



