using task_DEV2;
using NUnit.Framework;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    public class NUnitNegativeTestShockVowelSearch
    {
        [Test]
        [TestCase("оно")]
        [TestCase("молоко")]
        [TestCase("молок+о")]
        [TestCase("псв")]
        public void NegativeTestShockVowelSearch(string inputedWord)
        {
            PhoneticConverter test = new PhoneticConverter(inputedWord);
            Assert.Throws<CustomException>(() => test.ShockVowelSearch(inputedWord));
        }
    }
}
    
