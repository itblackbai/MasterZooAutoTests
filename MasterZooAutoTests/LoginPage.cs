using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterZooAutoTests
{
    public class LoginPage : BaseObjectPage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private By registrationLocator => By.XPath("/html//section[@id='sign-in']//a[@href='#j-popup-tab-signup']/span[@class='login-tabs-txt']");


        public RegistrationPage ClickRegistrationPage()
        {
            Console.WriteLine("Open registration page");
            Click(registrationLocator);
            Thread.Sleep(1000);
            return new RegistrationPage(_driver);
        }
    }
}
