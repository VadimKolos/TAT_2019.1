using NUnit.Framework;
using task_DEV2;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    public class NUnitTestDoubleSoundVowelsReplace
    {
        [TestCase("лё+д", "лё+д")]
        [TestCase("рю+мка", "рю+мка")]
        [TestCase("ря+дом", "ря+дом")]
        [TestCase("телеви+зор", "телеви+зор")]
        [TestCase("я+рд", "йа+рд")]
        [TestCase("ё+лка", "йо+лка")]
        [TestCase("е+сли", "йэ+сли")]
        [TestCase("ю+ла", "йу+ла")]
        [Test]
        public void TestDoubleSoundVowelsReplace(string inputedWord, string result)
        {
            PhoneticConverter test = new PhoneticConverter(inputedWord);
            string tests = test.DoubleSoundVowelsReplace(inputedWord);
            Assert.AreEqual(tests, result);
        }
    }
}