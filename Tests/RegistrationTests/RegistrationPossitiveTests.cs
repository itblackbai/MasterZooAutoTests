using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterZooAutoTests;
using MasterZooAutoTests.TestData;

namespace Tests.RegistrationTest
{
    public class RegistrationPossitiveTests : BaseTest
    {
        private RegistrationTestData testData = new RegistrationTestData();

        [Test]
        public void PossitiveRegistrationTest()
        {
            Console.WriteLine("Starting Possitive Registration Test ");

            Console.WriteLine("Open page : ");
            MainPageObject mainPage = new MainPageObject(_driver);
            mainPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on login : ");
            LoginPage loginPage = mainPage.ClickLoginPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on registration : ");
            RegistrationPage registrationPage = loginPage.ClickRegistrationPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Enter full name , email and password  : ");
            AccountPage accountPage = registrationPage.LogIn(
                testData.PossitiveFullName, testData.PossitiveEmail, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");


            //verification
            accountPage.ClickOnClose();
            accountPage.ClickOnProfile();
            Console.WriteLine("Click on profile ");
            ProfilePage profilePage = accountPage.ClickPersonalData();
            Console.WriteLine("--------------OK!------------");

            string currentUrl = profilePage.GetCurrentlyUrl();
            Assert.AreEqual(currentUrl, testData.ProfileUrl);
            Console.WriteLine("--------------OK!------------");

        }


        [Test]
        public void PossitiveRegistrationWithPasswordEightSymbolsTest()
        {
            Console.WriteLine("Starting Possitive Registration Test ");

            Console.WriteLine("Open page : ");
            MainPageObject mainPage = new MainPageObject(_driver);
            mainPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on login : ");
            LoginPage loginPage = mainPage.ClickLoginPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on registration : ");
            RegistrationPage registrationPage = loginPage.ClickRegistrationPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Enter full name , email and password  : ");
            AccountPage accountPage = registrationPage.LogIn(
                testData.PossitiveFullName, testData.PossitiveEmailForEightSymbol, testData.PasswordEight);
            Console.WriteLine("--------------OK!------------");


            //verification
            accountPage.ClickOnClose();
            accountPage.ClickOnProfile();
            Console.WriteLine("Click on profile ");
            ProfilePage profilePage = accountPage.ClickPersonalData();
            Console.WriteLine("--------------OK!------------");

            string currentUrl = profilePage.GetCurrentlyUrl();
            Assert.AreEqual(currentUrl, testData.ProfileUrl);
            Console.WriteLine("--------------OK!------------");

        }


        [Test]
        public void PossitiveRegistrationWithPasswordFifteenSymbolsTest()
        {
            Console.WriteLine("Starting Possitive Registration Test ");

            Console.WriteLine("Open page : ");
            MainPageObject mainPage = new MainPageObject(_driver);
            mainPage.OpenPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on login : ");
            LoginPage loginPage = mainPage.ClickLoginPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Click on registration : ");
            RegistrationPage registrationPage = loginPage.ClickRegistrationPage();
            Console.WriteLine("--------------OK!------------");

            Console.WriteLine("Enter full name , email and password  : ");
            AccountPage accountPage = registrationPage.LogIn(
                testData.PossitiveFullName, testData.PossitiveEmailForFifteenSymbol, testData.PasswordFifteen);
            Console.WriteLine("--------------OK!------------");


            //verification
            accountPage.ClickOnClose();
            accountPage.ClickOnProfile();
            Console.WriteLine("Click on profile ");
            ProfilePage profilePage = accountPage.ClickPersonalData();
            Console.WriteLine("--------------OK!------------");

            string currentUrl = profilePage.GetCurrentlyUrl();
            Assert.AreEqual(currentUrl, testData.ProfileUrl);
            Console.WriteLine("--------------OK!------------");

        }
    }
}
