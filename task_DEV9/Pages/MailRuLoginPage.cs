using OpenQA.Selenium;
using task_DEV9.WebDriver;

namespace task_DEV9.Pages
{ 
    /// <summary>
    /// This class works login page of mail ru.
    /// </summary>
    public class MailRuLoginPage : BasePage
    {
        public MailRuLoginPage(IWebDriver driver) : base(driver)
        {
        }       

        private IWebElement elementLogin => driver.FindElement(By.XPath("//input[@id='mailbox:login']"));
        private IWebElement elementPassword => driver.FindElement(By.XPath("//input[@id='mailbox:password']"));
        private IWebElement elementSubmit => driver.FindElement(By.XPath("//input[@class='o-control']"));
        private IWebElement errorMessage => driver.FindElement(By.XPath("//div[@id='mailbox:error']"));

        /// <summary>
        /// This method logs-in user.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public void LoginMailRu(string login, string password)
        {
            elementLogin.SendKeys(login);
            elementPassword.SendKeys(password);
            elementSubmit.Click();
        }

        /// <summary>
        /// This method returns true if the error message was enabled.
        /// </summary>
        /// <returns></returns>
        public bool LoginErrorMessageIsDisplayed()
        {
            return errorMessage.Enabled;
        }       
    }
}
