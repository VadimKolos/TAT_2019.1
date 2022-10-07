using OpenQA.Selenium;
using System;
using task_DEV9.WebDriver;

namespace task_DEV9.Pages
{
    /// <summary>
    /// This class works with login page of Gmail.
    /// </summary>
    public class GmailLoginPage : BasePage
    {
        public GmailLoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement gmailElementLogin => driver.FindElement(By.XPath("//input[@id='identifierId']"));
        private IWebElement gmailElementLoginSubmit => driver.FindElement(By.XPath("//span[text()='Далее']"));
        private IWebElement gmailElementPassword => driver.FindElement(By.XPath("//input[@name='password']"));

        /// <summary>
        /// This method logs-in user.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public void LoginGMail(string login, string password)
        {
            gmailElementLogin.SendKeys(login);
            gmailElementLoginSubmit.Click();
            gmailElementPassword.SendKeys(password);
            gmailElementPassword.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }
    }
}
