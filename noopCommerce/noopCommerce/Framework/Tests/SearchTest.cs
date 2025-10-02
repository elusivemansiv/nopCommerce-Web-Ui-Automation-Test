using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace noopCommerce.Framework.Tests
{
    internal class SearchTest : BaseTest
    {
        [Test]
        public void searchTest()
        {
            var homePage = new HomePage();
            homePage.searchItemStore();

        }
    }
}