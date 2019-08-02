using OpenQA.Selenium;
using task_DEV9.WebDriver;

namespace task_DEV9.Pages
{
    /// <summary>
    /// This class works with chat page of mail ru.
    /// </summary>
    public class MessagePage : BasePage
    {
        public MessagePage(IWebDriver driver) : base(driver)
        {
            
        }

        private IWebElement senderLogin;  
        private IWebElement message;

        /// <summary>
        /// This method returns true if the correct message was displayed.
        /// </summary>
        /// <param name="textOfMessage"></param>
        /// <returns></returns>
        public bool MessageIsReaded(string textOfMessage)
        {
            message = driver.FindElement(By.XPath("//span[text()='" + textOfMessage +"']"));
            return message.Displayed;
        }

        /// <summary>
        /// This method returns true if the name of sender was displayed.
        /// </summary>
        /// <param name="senderName"></param>
        /// <returns></returns>
        public bool CheckingCorrectSender(string senderName)
        {
            senderLogin = driver.FindElement(By.XPath("//div[@data-contact-informer-email='"+ senderName +"@gmail.com']"));
            return senderLogin.Displayed;
        }


    }
}
