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
        private By emailLocator => By.XPath("//form[@id='login_form_id']//input[@name='user[email]']");
        private By passwordLocator => By.XPath("//form[@id='login_form_id']//input[@name='user[pass]']");

        private By logInButton => By.XPath("//form[@id='login_form_id']//input[@value='Увійти']");
        private By resetPasswordButton => By.XPath("//form[@id='login_form_id']//a[@href='javascript:void(0);']");

        private By registrationLocator => By.XPath("//section[@id='sign-in']//a[@href='#j-popup-tab-signup']/span[@class='login-tabs-txt']");

        private By errorMessege => By.XPath("//form[@id='login_form_id']/div/div[@class=\"session-message s-error\"]");


        public RegistrationPage ClickRegistrationPage()
        {
            Console.WriteLine("Open registration page");
            Click(registrationLocator);
            Thread.Sleep(1000);
            return new RegistrationPage(_driver);
        }


        public ResetPasswordPage ClickResetPasswordPage()
        {
            Console.WriteLine("Open reset page");
            Click(resetPasswordButton);
            Thread.Sleep(1000);
            return new ResetPasswordPage(_driver);
        }

        public AccountPage LogIn(string email, string password)
        {
            Type(email, emailLocator);
            Type(password, passwordLocator);
            Find(logInButton).Click();
            return new AccountPage(_driver);
        }

        public string GetNegativeMessageText(string mess)
        {
            Thread.Sleep(1000);
            return Find(errorMessege).Text;
        }
    }
}
