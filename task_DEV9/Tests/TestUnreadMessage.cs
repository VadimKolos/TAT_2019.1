using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using task_DEV9.Pages;
using task_DEV9.WebDriver;

namespace task_DEV9.Tests
{
    public class TestUnreadMessage : BaseTest
    {
        private string gmailURL = "https://www.google.com/gmail/";
        private string mailRuURL = "https://mail.ru";
        private string mailRuLoginString = "vadimkolos1997";
        private string mailRuPasswordString = "ryot5462rza";

        [Test]
        [TestCase("arbitrary message", "fa3996005", "ryot5462rza")]
        public void UnreadMessageChecking(string message, string sender, string password)
        {
            WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));            
            BaseTest baseTest = new BaseTest();
            baseTest.GoToUrl(gmailURL);
            MailRuLoginPage loginPage = new MailRuLoginPage(driver);
            GmailLoginPage gmailLoginPage = new GmailLoginPage(driver);
            gmailLoginPage.LoginGMail(sender, password);           
            GmailMessage gmailMessage = new GmailMessage(driver);
            gmailMessage.SendMessage(message);
            Wait.Until(t => driver.FindElements(By.Id("link_vsm"))); 

            baseTest.GoToUrl(mailRuURL);
            loginPage.LoginMailRu(mailRuLoginString, mailRuPasswordString);
            Wait.Until(f => driver.FindElements(By.XPath("//div[text()='fake Account']")));
            MailRuHomePage homePage = new MailRuHomePage(driver);
            Assert.IsTrue(homePage.MessageIsUnread());
            Assert.IsTrue(homePage.MessageIsSended());

            Wait.Until(f => driver.FindElements(By.XPath("//div[text()='fake Account']")));
            homePage.ReadMessage();
            MessagePage messagePage = new MessagePage(driver);
            Assert.IsTrue(messagePage.MessageIsReaded(message));
            Assert.IsTrue(messagePage.CheckingCorrectSender(sender));
        }
    }
}
