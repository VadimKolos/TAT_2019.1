using OpenQA.Selenium;
using System.Collections.ObjectModel;
using task_DEV9.WebDriver;

namespace task_DEV9.Pages
{
    /// <summary>
    /// This class works with home page of MailRu.
    /// </summary>
    public class MailRuHomePage : BasePage
    {
        public MailRuHomePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement messageButton => driver.FindElement(By.XPath("//span[text()='Написать письмо']"));
        private IWebElement sendedMessage => driver.FindElement(By.XPath("//div[text()='fake Account']"));
        private IWebElement unreadedReceivedMessage => driver.FindElement(By.XPath("//div[text()='fake Account']"));

        ReadOnlyCollection<IWebElement> unreadMessages => driver.FindElements(By.XPath("//div[@class='b-letterstatus__icon ico " +
                "ico_letterstatus ico_letterstatus_onhover ico_letterstatus_unread']"));

        public void ReadMessage()
        {
            sendedMessage.Click();
        }

        public bool HomePageIsOpened()
        {
            return messageButton.Displayed;
        }

        public bool MessageIsSended()
        {
            return sendedMessage.Displayed;
        }

        public bool MessageIsUnread()
        {
            return unreadedReceivedMessage.Displayed;
        }
        
    }
}
