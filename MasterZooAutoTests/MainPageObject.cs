using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MasterZooAutoTests
{
    public class MainPageObject : BaseObjectPage
    {
        public MainPageObject(IWebDriver driver) : base(driver)
        {
        }

        // Main url
         private string pageUrl = "https://masterzoo.ua/ua/";

        //XPath
        private By loginButton => By.XPath("//*[@class=\"userbar__button __active\"]");

        public void OpenPage()
        {
            OpenUrl(pageUrl);
        }


        public LoginPage ClickLoginPage()
        {
            Console.WriteLine("Open login page");
            Click(loginButton);
            return new LoginPage(_driver);
        }



    }
}