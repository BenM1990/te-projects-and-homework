using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class DateFashionTests
    {
        [TestMethod]
        public void GetATableTest()
        {
            DateFashion dateFashion = new DateFashion();

            int you = 5;
            int date = 5;
            int result = 1;
           

            int actualResult = dateFashion.GetATable(you, date);

            CollectionAssert.Equals(result, actualResult);

            int youSecondInput = 5;
            int dateSecondInput = 2;
            int resultSecondInput = 0;

            int actualResultSecond = dateFashion.GetATable(youSecondInput, dateSecondInput);

            CollectionAssert.Equals(resultSecondInput, actualResultSecond);

            int youThirdInput = 5;
            int dateThirdInput = 10;
            int resultThirdInput = 2;

            int actualResultThird = dateFashion.GetATable(youThirdInput, dateThirdInput);

            CollectionAssert.Equals(resultThirdInput, actualResultThird);





        }
    }
}
/*
You and your date are trying to get a table at a restaurant. The parameter "you" is the stylishness
of your clothes, in the range 0..10, and "date" is the stylishness of your date's clothes. The result
getting the table is encoded as an int value with 0=no, 1=maybe, 2=yes. If either of you is very
stylish, 8 or more, then the result is 2 (yes). With the exception that if either of you has style of
2 or less, then the result is 0 (no). Otherwise the result is 1 (maybe).
dateFashion(5, 10) → 2
dateFashion(5, 2) → 0
dateFashion(5, 5) → 1
*/