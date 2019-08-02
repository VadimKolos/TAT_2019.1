using NUnit.Framework;
using task_DEV2;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    public class NUnitTestShockVowelSearch
    {
        [TestCase("молоко+", 5)]
        [TestCase("о+лово", 0)]
        [TestCase("ёлка", 0)]
        [TestCase("зелёный", 3)]
        [TestCase("я", 0)]
        [TestCase("он", 0)]
        [TestCase("ты", 1)]
        [TestCase("трон", 2)]        
        [Test]
        public void TestShockVowelSearch(string inputedWord, int result)
        {
            PhoneticConverter expectedResult = new PhoneticConverter(inputedWord);
            int actualResults = expectedResult.ShockVowelSearch(inputedWord);
            Assert.AreEqual(actualResults, result);
        }
    }
}