using task_DEV9.Pages;
using task_DEV9.WebDriver;
using NUnit.Framework;

namespace task_DEV9
{    
    class CorrectLoginTest : BaseTest
    {    
        [Test]
        [TestCase("vadimkolos1997", "ryot5462rza")]
        public void LoginChecking(string login, string password)
        {
            string mailURL = "https://mail.ru";
            BaseTest baseTest = new BaseTest();
            baseTest.GoToUrl(mailURL);
            MailRuLoginPage loginPage = new MailRuLoginPage(driver);
            loginPage.LoginMailRu(login, password);
            MailRuHomePage homePage = new MailRuHomePage(driver);
            Assert.IsTrue(homePage.HomePageIsOpened());            
        }        
    }
}

