using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterZooAutoTests
{
    public class AccountPage : BaseObjectPage
    {
        public AccountPage(IWebDriver driver) : base(driver)
        {
        }

       
        private By closeButton = By.XPath("//div[@id='modal-overlay']/section[@class='popup']//span[@class='btn-content']");
        
        private By profileList = By.XPath("//*[@class=\"userbar__button\"]");
        private By personalDataButton => By.XPath("//*[@href=\"/ua/profile/\"]");

        private By errorMessegeWithTheSameEmail => By.XPath("//form[@id='signup-form']//div[@class='form-error']//div[@class='form-error-box errorBox-message']");
        private By errorMessegeWithThePassword => By.XPath("//form[@id='signup-form']//div[@class='form-error']//div[@class='form-error-box errorBox-message']");

        public AccountPage ClickOnClose()
        {
            Console.WriteLine("Click on close button");
            Click(closeButton);
            return new AccountPage(_driver);
        }
        public AccountPage ClickOnProfile()
        {
            Console.WriteLine("Click on profile button");
            Find(profileList).Click();
            return new AccountPage(_driver);
        }
        public ProfilePage ClickPersonalData()
        {
            Console.WriteLine("Open profile page");
            Find(personalDataButton).Click();
            return new ProfilePage(_driver);
        }

        public string GetNegativeMessageText(string mess)
        {
            Thread.Sleep(1000);
            return Find(errorMessegeWithTheSameEmail).Text;
        }
    }
}
