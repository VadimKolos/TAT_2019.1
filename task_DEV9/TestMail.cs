using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text;
using System;

namespace task_DEV9
{
    /// <summary>
    /// Class UnreadMessages implements methods of getting unreaded messags.
    /// </summary>
    class TestMail
    {
        /// <summary>
        /// Method GetUnreadedMessages for getting unreaded messags.
        /// </summary>
        /// <returns>StringBuilder object with unreaded messages.></returns>
        public StringBuilder GetUnreadedMessages()
        {
            var messages = new StringBuilder();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--disable-notifications");
            IWebDriver browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(@"https://www.gmail.com/");

            browser.FindElement(By.Id("email")).SendKeys("+375293288028");
            browser.FindElement(By.Id("pass")).SendKeys("17505701");
            browser.FindElement(By.Id("loginbutton")).Click();
            browser.FindElement(By.XPath("//*[@id='left_nav_section_nodes']/div/ul/li[2]")).Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var listMessages = browser.FindElements(By.XPath
                ("//*[@id='globalContainer']/div/div/div/div/div/div[2]/div[3]/div/div/div/div/div[2]/div/ul/li/div/a/div/div[2]/div[2]/span/span"));
            foreach (IWebElement iw in listMessages)
            {
                messages.Append(iw.Text + '\n');
            }
            return messages;
        }
    }
}
