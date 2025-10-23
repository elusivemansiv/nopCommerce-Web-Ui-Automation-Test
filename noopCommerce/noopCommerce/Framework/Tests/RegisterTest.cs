using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Tests
{
    internal class RegisterTest : BaseTest
    {
        [Test]
        public void registerTest()
        {
            var registerPage = new RegisterPage();
            registerPage.registerPageTest();

        }
    }
}