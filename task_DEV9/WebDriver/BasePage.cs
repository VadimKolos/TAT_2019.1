using OpenQA.Selenium;

namespace task_DEV9.WebDriver
{
    /// <summary>   
    /// Base class for pages.
    /// </summary>
    public class BasePage
    {
        protected IWebDriver driver = null;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
