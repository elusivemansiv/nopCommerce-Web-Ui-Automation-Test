using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace noopCommerce.Framework.Tests
{
    internal class HomeTest : BaseTest
    {
        [Test]
        public void MainPageTest()
        {
            var homePage = new HomePage();
            homePage.homePageTest();

        }
    }
}