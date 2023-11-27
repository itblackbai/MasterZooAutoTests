using MasterZooAutoTests;
using MasterZooAutoTests.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.RegistrationTest
{
    public class RegistrationNegativeTests :BaseTest
    {
        private RegistrationTestData testData = new RegistrationTestData();

        [Test]
        public void NegativeRegistrationWithTheSameEmailTest()
        {
            Console.WriteLine("Starting Negative Registration With The Same Email Test ");

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
                testData.PossitiveFullName, testData.RegistredEmail, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");


            //verification
            
            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMassegeWithTheSameEmail);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMassegeWithTheSameEmail),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMassegeWithTheSameEmail + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }

        [Test]
        public void NegativeRegistrationWithPasswordLessThenEightSymbolsTest()
        {
            Console.WriteLine("Starting Negative Registration With Password Less Then Eight Symbols Test ");

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
                testData.PossitiveFullName, testData.PossitiveEmailForCheckPassError, testData.PasswordLessEight);
            Console.WriteLine("--------------OK!------------");


            //verification

            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMessegeWithThePassword);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithThePassword),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithThePassword + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }

        [Test]
        public void NegativeRegistrationWithPasswordMoreThenFifteenSymbolsTest()
        {
            Console.WriteLine("Starting Negative Registration With Password More Then Fifteen Symbols Test ");

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
                testData.PossitiveFullName, testData.PossitiveEmailForCheckPassError, testData.PasswordMoreTheFifteen);
            Console.WriteLine("--------------OK!------------");


            //verification

            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMessegeWithThePassword);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithThePassword),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithThePassword + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }


        [Test]
        public void NegativeRegistrationWithUnvalidSurnameAndNameByNumbersTest()
        {
            Console.WriteLine("Starting Negative Registration With Unvalid Surname And Name By Numbers Test ");

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
                testData.FullNameWithNumbers, testData.PossitiveEmailForCheckPassError, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");


            //verification
            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMessegeWithFullNameByNumber);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithFullNameByNumber),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithFullNameByNumber + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }

        [Test]
        public void NegativeRegistrationWithUnvalidSurnameAndNameBySymbolsTest()
        {
            Console.WriteLine("Starting Negative Registration With Unvalid Surname And Name By Symbols Test ");

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
                testData.FullNameWithSymbols, testData.PossitiveEmailForCheckPassError, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");


            //verification
            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMessegeWithFullNameBySymbol);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithFullNameBySymbol),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithFullNameBySymbol + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }

        [Test]
        public void NegativeRegistrationWithEmptyFieldsTest()
        {
            Console.WriteLine("Starting Negative Registration With Empty Fiels Test ");

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
                testData.FullNameWithSymbols, testData.PossitiveEmailForCheckPassError, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");


            //verification
            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMessegeWithFullNameBySymbol);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithFullNameBySymbol),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithFullNameBySymbol + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }

        [Test]
        public void NegativeRegistrationWithUnvalidEmailWithOutPointTest()
        {
            Console.WriteLine("Starting Negative Registration With Unvalid Email With Out Point  Test ");

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
                testData.PossitiveFullName, testData.NegativeEmailWithSymbols, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");


            //verification
            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMessegeWithFullNameBySymbol);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithFullNameBySymbol),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithFullNameBySymbol + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }
        [Test]
        public void NegativeRegistrationWithUnvalidEmailWithSymbolsTest()
        {
            Console.WriteLine("Starting Negative Registration With Unvalid Email With Symbols  Test ");

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
                testData.PossitiveFullName, testData.NegativeEmailWithOutPoint, testData.PossitivePassword);
            Console.WriteLine("--------------OK!------------");


            //verification
            string actualSuccessMassege = accountPage.GetNegativeMessageText(testData.ErrorMessegeWithEmptyEmail);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithEmptyEmail),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithEmptyEmail + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");
        }
    }
}
