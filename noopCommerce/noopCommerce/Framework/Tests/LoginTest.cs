using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace noopCommerce.Framework.Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]

        public void ValidloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageValidTest();

        }

        [Test]

        public void InValidEmailloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageInValidEmailTest();

        }

        [Test]

        public void InValidPassloginTest()
        {
            var loginPage = new LoginPage();
            loginPage.loginPageInValidPassTest();

        }

        [Test]

        public void NoEmailloginTest()
        {
            var loginPage = new LoginPage();
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

        }

    }
}
