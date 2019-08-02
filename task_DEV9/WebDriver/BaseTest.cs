using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace task_DEV9.WebDriver
{
    /// <summary>   
    /// Base class for tests.
    /// </summary>
    public class BaseTest
    {
        protected static IWebDriver driver;

        /// <summary>        
        /// This method setup driver for test
        /// </summary>
        [SetUp]
        public virtual void InitTest()
        {
            driver = new ChromeDriver("C://SeleniumDriver");
            driver.Manage().Window.Maximize();                       
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void GoToUrl(string mailURL)
        {
            driver.Navigate().GoToUrl(mailURL);
        }

        /// <summary>
        ///This method quit from driver after test
        /// </summary>
        [TearDown]
        public virtual void CleanTest()
        {
            driver.Quit();
            driver = null;
        }
    }
}
