using OpenQA.Selenium;
using task_DEV9.WebDriver;

namespace task_DEV9
{
    /// <summary>   
    /// This class work with messages on gmail.
    /// </summary>
    public class GmailMessage : BasePage
    {
        public GmailMessage(IWebDriver driver) : base(driver)
        {
        }
 
        private IWebElement WriteMessage => driver.FindElement(By.XPath("//div[@class='T-I J-J5-Ji T-I-KE L3']"));
        private IWebElement recipientOfMessage => driver.FindElement(By.Name("to"));
        private IWebElement arbitraryMessage => driver.FindElement(By.XPath("//div[@class='Am Al editable LW-avf']"));
        private IWebElement sendArbitraryMessage => driver.FindElement(By.XPath("//div[@class='T-I J-J5-Ji aoO v7 T-I-atl L3']"));
        private string destination = "vadimkolos1997@mail.ru";

        /// <summary>
        /// This method sends message from gmail.
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(string message)
        {                        
            WriteMessage.Click();            
            recipientOfMessage.SendKeys(destination);           
            arbitraryMessage.SendKeys(message);
            sendArbitraryMessage.Click();                  
        }       
    }
}
