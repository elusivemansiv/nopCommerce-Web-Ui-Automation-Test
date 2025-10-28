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
<<<<<<< HEAD
            var loginEmail = testData.GetValue<string>("EmailInput");
            var loginPass = testData.GetValue<string>("PasswordInput");
            loginPage.loginPageValidTest(loginEmail, loginPass);
            browser.WaitForPageToLoad();
            Assert.That(browser.CurrentUrl.Contains("demo.nopcommerce.com"),"Login failed — user not redirected to home page.");
=======
            loginPage.loginPageValidTest();
>>>>>>> 7b244fa0232d43dfbcb49c24a833e8775ca06f59

        }

        [Test]
<<<<<<< HEAD
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with invalid email")]
=======
>>>>>>> 7b244fa0232d43dfbcb49c24a833e8775ca06f59

        public void InValidEmailloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageInValidEmailTest();
<<<<<<< HEAD
            Assert.That(loginPage.GetUnSuccessMessage().Contains("Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect"), "");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with invalid password")]
=======

        }

        [Test]
>>>>>>> 7b244fa0232d43dfbcb49c24a833e8775ca06f59

        public void InValidPassloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageInValidPassTest();
<<<<<<< HEAD
            Assert.That(loginPage.GetUnSuccessMessage().Contains("Login was unsuccessful. Please correct the errors and try again.\r\nThe credentials provided are incorrect"), "");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://demo.nopcommerce.com/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with no email")]
=======

        }

        [Test]
>>>>>>> 7b244fa0232d43dfbcb49c24a833e8775ca06f59

        public void NoEmailloginTest()
        {
            var loginPage = new LoginPage();
<<<<<<< HEAD
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
=======
            loginPage.loginPageNoEmailTest();

        }

        [Test]

        public void NoPassloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageNoPassword();

        }

        [Test]

        public void InValidNodataloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageNoDataTest();

>>>>>>> 7b244fa0232d43dfbcb49c24a833e8775ca06f59
        }

    }
}
