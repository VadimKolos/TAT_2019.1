using NUnit.Framework;
using task_DEV2;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    public class NUnitTestOAReplace
    {
        [TestCase("молоко+", 5, "малако")]
        [TestCase("о+скар", 0, "оскар")]
        [TestCase("си+ний", 1, "синий")]
        [Test]
        public void TestOAReplace(string inputedWord, int indexOfShockConst, string result)
        {
            PhoneticConverter test = new PhoneticConverter(inputedWord);
            string tests = test.OAReplace(inputedWord, indexOfShockConst);
            Assert.AreEqual(tests, result);
        }
    }
}
