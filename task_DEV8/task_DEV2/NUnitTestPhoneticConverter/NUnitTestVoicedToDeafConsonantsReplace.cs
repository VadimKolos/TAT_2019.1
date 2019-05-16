using NUnit.Framework;
using task_DEV2;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    class NUnitTestVoicedToDeafConsonantsReplace
    {
        [TestCase("ска+зка", "ска+ска")]
        [TestCase("зу+б", "зу+п")]        
        [Test]
        public void TestVoicedToDeafConsonantsReplace(string inputedWord, string result)
        {
            PhoneticConverter test = new PhoneticConverter(inputedWord);
            string tests = test.VoicedToDeafConsonantsReplace(inputedWord);
            Assert.AreEqual(tests, result);
        }
    }
}