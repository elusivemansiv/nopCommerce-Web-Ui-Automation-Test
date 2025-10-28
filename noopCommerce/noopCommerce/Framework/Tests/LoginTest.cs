using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;


namespace noopCommerce.Framework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    internal class LoginTest : BaseTest
    {
        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with valid data")]

        public void ValidloginTest()
        {
            var loginPage = new LoginPage();
            var loginEmail = testData.GetValue<string>("EmailInput");
            var loginPass = testData.GetValue<string>("PasswordInput");
            loginPage.loginPageValidTest(loginEmail, loginPass);
            browser.WaitForPageToLoad();
            Assert.That(browser.CurrentUrl.Contains("demo.nopcommerce.com"),"Login failed — user not redirected to home page.");

        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with invalid email")]

        public void InValidEmailloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageInValidEmailTest();
            Assert.That(loginPage.GetUnSuccessMessage().Contains("Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect"), "");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with invalid password")]

        public void InValidPassloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageInValidPassTest();
            Assert.That(loginPage.GetUnSuccessMessage().Contains("Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect"), "");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with no email")]

        public void NoEmailloginTest()
        {
            var loginPage = new LoginPage();
            var loginPass = testData.GetValue<string>("PasswordInput");
            loginPage.loginPageNoEmailTest(loginPass);
            Assert.That(loginPage.GetFormValidationMessage().Contains("Please enter your email"), "");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with no password")]
        public void NoPassloginTest()
        {
            var loginPage = new LoginPage();
            var loginEmail = testData.GetValue<string>("EmailInput");
            loginPage.loginPageNoPassword(loginEmail);
            Assert.That(loginPage.GetUnSuccessMessage().Contains("Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect"), "");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with No data")]
        public void NodataloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageNoDataTest();
            Assert.That(loginPage.GetFormValidationMessage().Contains("Please enter your email"), "");
        }

    }
}
