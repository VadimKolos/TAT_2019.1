using NUnit.Framework;
using task_DEV2;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    class NUnitTestDeafToVoicedConsonantsReplace
    {
        [TestCase("сбо+й", "збо+й")]        
        [TestCase("сгни+ть", "згни+т'")]        
        [Test]
        public void TestDeafToVoicedConsonantsReplace(string inputedWord, string result)
        {
            PhoneticConverter test = new PhoneticConverter(inputedWord);
            string tests = test.DeafToVoicedConsonantsReplace(inputedWord);
            Assert.AreEqual(tests, result);
        }
    }
}
