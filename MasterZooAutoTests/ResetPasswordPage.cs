using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterZooAutoTests
{
    public class ResetPasswordPage : BaseObjectPage
    {
        public ResetPasswordPage(IWebDriver driver) : base(driver)
        {
        }


        private By emailLocator => By.XPath("//form[@id='password-recovery-form']//input[@name='user[email]']");
        private By recoveryButton => By.XPath("//form[@id='password-recovery-form']//input[@value='Відновити']");

        private By successfulRecoveryMessage => By.XPath("//div[@class='popup-msg j-recovery-message']");

        private By negitiveRecoveryMessege => By.XPath("//*[@class='form-error-box errorBox-message']");


        public ResetPasswordPage InputEmail(string email)
        {
            Type(email, emailLocator);
            Find(recoveryButton).Click();
            return new ResetPasswordPage(_driver);
        }

        public string GetNegativeMessageText(string mess)
        {
            Thread.Sleep(1000);
            return Find(successfulRecoveryMessage).Text;
        }

        public string GetNegativeMessageForUnregistredText(string mess)
        {
            Thread.Sleep(1000);
            return Find(negitiveRecoveryMessege).Text;
        }

    }
}
