using MasterZooAutoTests.TestData;
using MasterZooAutoTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.LoginTests
{
    public class LoginPossitiveTests : BaseTest
    {
        private RegistrationTestData testData = new RegistrationTestData();

        [Test]
        public void PossitiveLoginWithValidTestDataTest()
        {
            Console.WriteLine("Starting Possitive Login Test ");

            Console.WriteLine("Open page : ");
            MainPageObject mainPage = new MainPageObject(_driver);
            mainPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on login : ");
            LoginPage loginPage = mainPage.ClickLoginPage();
            Console.WriteLine("--------------OK!------------");


            Console.WriteLine("Enter email and password  : ");
            AccountPage accountPage = loginPage.LogIn( 
                testData.RegistredEmail, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");

            //verification
            //accountPage.ClickOnClose();
            accountPage.ClickOnProfile();
            Console.WriteLine("Click on profile ");
            ProfilePage profilePage = accountPage.ClickPersonalData();
            Console.WriteLine("--------------OK!------------");

            string currentUrl = profilePage.GetCurrentlyUrl();
            Assert.AreEqual(currentUrl, testData.ProfileUrl);
            Console.WriteLine("--------------OK!------------");


        }

        [Test]
        public void PossitiveLoginWithUnvalidTestDataByEmailTest()
        {
            Console.WriteLine("Starting Possitive Login With Unvalid Test Data By Email Test");

            Console.WriteLine("Open page : ");
            MainPageObject mainPage = new MainPageObject(_driver);
            mainPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on login : ");
            LoginPage loginPage = mainPage.ClickLoginPage();
            Console.WriteLine("--------------OK!------------");


            Console.WriteLine("Enter email and password  : ");
            AccountPage accountPage = loginPage.LogIn(
                testData.PossitiveEmailForCheckPassError, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");



            //verification
            string actualSuccessMassege = loginPage.GetNegativeMessageText(testData.ErrorMessegeOnLoginPage);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeOnLoginPage),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeOnLoginPage + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");

            

        }

        [Test]
        public void PossitiveLoginWithUnvalidTestDataByPasswordTest()
        {
            Console.WriteLine("Starting Possitive Login With Unvalid Test Data By Password Test");

            Console.WriteLine("Open page : ");
            MainPageObject mainPage = new MainPageObject(_driver);
            mainPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on login : ");
            LoginPage loginPage = mainPage.ClickLoginPage();
            Console.WriteLine("--------------OK!------------");


            Console.WriteLine("Enter email and password  : ");
            AccountPage accountPage = loginPage.LogIn(
                testData.RegistredEmail, testData.PasswordFifteen);
            Console.WriteLine("--------------OK!------------");

            //verification
            string actualSuccessMassege = loginPage.GetNegativeMessageText(testData.ErrorMessegeOnLoginPage);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeOnLoginPage),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeOnLoginPage + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");

        }

        [Test]
        public void PossitiveLoginResetPasswordWithValidDataTest()
        {
            Console.WriteLine("Starting Possitive Login Reset Password With Valid Data Test");

            Console.WriteLine("Open page : ");
            MainPageObject mainPage = new MainPageObject(_driver);
            mainPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on login : ");
            LoginPage loginPage = mainPage.ClickLoginPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on reset button : ");
            ResetPasswordPage resetPassword = loginPage.ClickResetPasswordPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Enter email : ");
            resetPassword.InputEmail(testData.RegistredEmail);
            Console.WriteLine("--------------OK!------------");


            
            //verification
            string actualSuccessMassege = resetPassword.GetNegativeMessageText(testData.recoverMessege);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.recoverMessege),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.recoverMessege + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
            
        }
    }
}
