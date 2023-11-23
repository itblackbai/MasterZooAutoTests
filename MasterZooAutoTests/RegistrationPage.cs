using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterZooAutoTests
{
    public class RegistrationPage : BaseObjectPage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        private By fullNameLocator => By.XPath("//*[@name=\"user[title]\"]");
        private By emailLocator => By.XPath("//form[@id='signup-form']//input[@name='user[email]']");
        private By passwordLocator => By.XPath("//form[@id='signup-form']//input[@name='user[pass]']");

        private By registerButton1 = By.XPath("//form[@id='signup-form']//input[@value='Зареєструватись']");

        

        public AccountPage LogIn(string username,string email, string password)
        {
            Type(username, fullNameLocator);
            Type(email, emailLocator);
            Type(password, passwordLocator);
            Find(registerButton1).Click();
            return new AccountPage(_driver);
        }

       
    }
}


