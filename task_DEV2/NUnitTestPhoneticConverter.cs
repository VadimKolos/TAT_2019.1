using NUnit.Framework;

namespace task_DEV2
{
    [TestFixture]
    class NUnitTestPhoneticConverter
    {
        PhoneticConverter test = new PhoneticConverter("");

        [TestCase("молоко+", "малако")]
        [TestCase("о+лово", "олава")]
        [Test]
        public void TestOAReplace(string inputedWord, int indexOfShockConst, string result)
        {
            string tests = test.OAReplace( inputedWord,  indexOfShockConst);
            Assert.AreEqual(tests, result);
        }
    }
}
