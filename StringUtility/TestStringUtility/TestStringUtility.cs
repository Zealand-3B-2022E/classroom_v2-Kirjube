using StringUtility;
namespace TestStringUtility
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "y";
            int expectedResult = 1;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;
            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SearchShouldBeCaseSensitive()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "s";
            int expectedResult = 2;
            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SearchResultifStringIsNull()
        {
            string stringToCheck = null;
            string stringToFind = "k";
            int expectedResult = -1;
            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}