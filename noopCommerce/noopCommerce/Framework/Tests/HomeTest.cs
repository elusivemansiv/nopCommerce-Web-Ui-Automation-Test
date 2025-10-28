using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace noopCommerce.Framework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    internal class HomeTest : BaseTest
    {
        [Test]
        [AllureSeverity]
        [AllureLink("Website", "")]
        [AllureSuite("Browser tests")]
        [AllureDescription("")]
        public void homeTest()
        {
            var homePage = new HomePage();
            homePage.homePageTest();

        }
    }
}