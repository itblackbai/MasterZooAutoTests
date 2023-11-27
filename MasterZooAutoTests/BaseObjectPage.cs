using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterZooAutoTests
{
    public class BaseObjectPage
    {
        protected IWebDriver _driver;

        public BaseObjectPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //Open url
        protected void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        //Find element using locatore
        protected IWebElement Find(By locator)
        {
            return _driver.FindElement(locator);
        }
        // Click on element with given locator when its visible 
        protected void Click(By locator)
        {
            WaitForVisibilityOf(locator, 5);
            Find(locator).Click();
        }

        // Click on element with given locator when its visible 
        protected void ClickByXPath(By locator)
        {
            WaitForVisibilityOf(locator, 5);
            Find(locator).Click();
        }

        // Type given text into element with given locator 
        protected void Type(string text, By locator)
        {
            WaitForVisibilityOf(locator, 5);
            Find(locator).SendKeys(text);
        }
        //Get currentlyUrl
        public string GetCurrentlyUrl()
        {
            return _driver.Url;
        }
        //Get currently page sourse
        public string GetCurrentlyPageSource()
        {
            return _driver.PageSource;
        }


        private void WaitFor(Func<IWebDriver, IReadOnlyCollection<IWebElement>> condition, int? timeOutInSeconds)
        {
            timeOutInSeconds = timeOutInSeconds != null ? timeOutInSeconds : 30;
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeOutInSeconds.Value));
            wait.Until(condition);
        }


        protected void WaitForVisibilityOf(By locator, params int[] timeOutInSeconds)
        {
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitFor(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator),
                            (timeOutInSeconds.Length > 0 ? timeOutInSeconds[0] : (int?)null));
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
        }
        // Key presses
        protected void PressesKey(By locator, string key)
        {
            Find(locator).SendKeys(key);
        }


        //Switch to IFrame using it's locator 
        protected void SwitchToFrame(By frameLocator)
        {
            _driver.SwitchTo().Frame(Find(frameLocator));
        }

       

    }
}
