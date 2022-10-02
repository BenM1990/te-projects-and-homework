using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class CigarPartyTests
    {
        [TestMethod]
        public void HavePartyTest()
        {
            CigarParty cigarParty = new CigarParty();

            int firstInput = 30;
            bool secondInput = false;

            bool actualResult = cigarParty.HaveParty(firstInput, secondInput);

            bool expectedResult = false;

            CollectionAssert.Equals(expectedResult, actualResult);
        }
            [DataTestMethod]
            [DataRow(40, true)]
            [DataRow(41, true)]
            [DataRow(42, true)]
            [DataRow(43, true)]
            [DataRow(44, true)]
            [DataRow(45, true)]
            [DataRow(46, true)]
            [DataRow(47, true)]
            [DataRow(48, true)]
            [DataRow(49, true)]
            [DataRow(50, true)]
            [DataRow(51, true)]
            [DataRow(52, true)]
            [DataRow(53, true)]
            [DataRow(54, true)]
            [DataRow(55, true)]
            [DataRow(56, true)]
            [DataRow(57, true)]
            [DataRow(58, true)]
            [DataRow(59, true)]
            [DataRow(60, true)]
            public void HavePartyTest(int numberOfCigars, bool partyReturn)
            {
                int input = numberOfCigars;
                bool result = partyReturn;

            Assert.AreEqual(partyReturn, result);
                
            }
            


        }

    }

