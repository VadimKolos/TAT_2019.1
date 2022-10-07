using task_DEV9.Pages;
using task_DEV9.WebDriver;
using NUnit.Framework;

namespace task_DEV9.Tests
{
    class IncorrectLoginTests : BaseTest
    {
        [Test]
        [TestCase("vadimkolos1997", "wrongPassword")]
        [TestCase("wrongLigin", "ryot5462rza")]
        [TestCase("wrongLigin", "wrongPassword")]
        [TestCase("vadimkolos1997", "")]
        [TestCase("", "ryot5462rza")]
        [TestCase("", "")]
        public void LoginChecking(string login, string password)
        {
            string mailURL = "https://mail.ru";
            BaseTest baseTest = new BaseTest();
            baseTest.GoToUrl(mailURL);
            MailRuLoginPage loginPage = new MailRuLoginPage(driver);
            loginPage.LoginMailRu(login, password);            
            Assert.IsTrue(loginPage.LoginErrorMessageIsDisplayed());
        }
    }
}
