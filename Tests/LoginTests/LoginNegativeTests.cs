using MasterZooAutoTests;
using MasterZooAutoTests.TestData;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.LoginTests
{
    public class LoginNegativeTests : BaseTest
    {
        private RegistrationTestData testData = new RegistrationTestData();
        
        [Test]
        public void NegativeLoginResetPasswordWithUnvalidDataTest()
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
            resetPassword.InputEmail(testData.PossitiveEmailForCheckPassError);
            Console.WriteLine("--------------OK!------------");



            //verification
            string actualSuccessMassege = resetPassword.GetNegativeMessageForUnregistredText(testData.recoverMessegeWithUnvalidData);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.recoverMessegeWithUnvalidData),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.recoverMessegeWithUnvalidData + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");

        }

        [Test]
        public void NegativeLoginResetPasswordWithEmptyFieldsTest()
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
            resetPassword.InputEmail(testData.EmptyEmail);
            Console.WriteLine("--------------OK!------------");



            //verification
            string actualSuccessMassege = resetPassword.GetNegativeMessageForUnregistredText(testData.ErrorMessegeWithEmptyEmail);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.ErrorMessegeWithEmptyEmail),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.ErrorMessegeWithEmptyEmail + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");

        }


        [Test]
        public void NegativeLoginResetPasswordWithUnvalidEmailTest()
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
            resetPassword.InputEmail(testData.NegativeEmailWithOutPoint);
            Console.WriteLine("--------------OK!------------");



            //verification
            string actualSuccessMassege = resetPassword.GetNegativeMessageForUnregistredText(testData.recoverMessegeWithUnvalidData);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.recoverMessegeWithUnvalidData),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.recoverMessegeWithUnvalidData + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");

        }

        [Test]
        public void NegativeLoginResetPasswordWithUnvalidEmailWithSymbolsTest()
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
            resetPassword.InputEmail(testData.NegativeEmailWithSymbols);
            Console.WriteLine("--------------OK!------------");



            //verification
            string actualSuccessMassege = resetPassword.GetNegativeMessageForUnregistredText(testData.recoverMessegeWithUnvalidData);
            Console.WriteLine(actualSuccessMassege);
            Assert.True(actualSuccessMassege.Contains(testData.recoverMessegeWithUnvalidData),
                 "actualSuccessMessage does not contain expectedSuccessMessage\nexpectedSuccessMessage: "
                         + testData.recoverMessegeWithUnvalidData + "\nactualSuccessMessage: " + actualSuccessMassege);

            Console.WriteLine("--------------OK!------------");

        }
    }
}
