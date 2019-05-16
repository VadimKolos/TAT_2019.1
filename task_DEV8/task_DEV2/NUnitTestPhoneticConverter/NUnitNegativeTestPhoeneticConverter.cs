using task_DEV2;
using NUnit.Framework;

namespace NUnitTestPhoneticConverter
{
    [TestFixture]
    public class NUnitNegativeTestPhoeneticConverter
    {
        [Test]
        [TestCase("z")]
        [TestCase("м4")]
        [TestCase("4")]
        [TestCase("234574")]
        [TestCase("ёкё")]
        [TestCase("Я+блоко")]
        [TestCase("A+pple")]
        [TestCase("ло+дка+")]
        [TestCase("иду+ домой")]
        [TestCase("U")]
        [TestCase("U+")]
        [TestCase("U+no")]
        [TestCase("оно+~")]
        [TestCase("оно+`")]
        [TestCase("оно+!")]
        [TestCase("оно+@")]
        [TestCase("оно+#")]
        [TestCase("оно+$")]
        [TestCase("оно+%")]
        [TestCase("оно+^")]
        [TestCase("оно+&")]
        [TestCase("оно+*")]
        [TestCase("оно+(")]
        [TestCase("оно+)")]
        [TestCase("оно+/")]
        [TestCase("оно+?")]
        [TestCase("оно+.")]
        [TestCase("оно+,")]
        [TestCase("оно+<")]
        [TestCase("оно+>")]
        [TestCase("оно+~")]
        [TestCase("оно+;")]
        [TestCase("оно+:")]
        public void NegativeTestPhoeneticConverter(string inputedWord)
        {
            Assert.Throws<CustomException>(() => new PhoneticConverter(inputedWord));
        }
    }
}
