using NUnit.Framework;
using task_DEV2;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    public class NUnitTestSoftConsonantReplace
    {
        [TestCase("лё+д", "л'о+д")]
        [TestCase("рю+мка", "р'у+мка")]
        [TestCase("ря+дом", "р'а+дом")]
        [TestCase("телеви+зор", "т'эл'эви+зор")]
        [TestCase("я+рд", "я+рд")]
        [TestCase("ё+лка", "ё+лка")]
        [TestCase("е+сли", "е+сли")]
        [TestCase("ю+ла", "ю+ла")]
        [Test]
        public void TestSoftConsonantReplace(string inputedWord, string result)
        {
            PhoneticConverter test = new PhoneticConverter(inputedWord);
            string tests = test.SoftConsonantsReplace(inputedWord);
            Assert.AreEqual(tests, result);
        }
    }
}

