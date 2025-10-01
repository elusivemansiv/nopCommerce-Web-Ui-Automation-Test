using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using NUnit.Framework;

namespace noopCommerce.Framework
{
    internal class BaseTest
    {
        protected Browser browser;
        protected static readonly JsonSettingsFile settings = new("config.json");
        protected static readonly JsonSettingsFile testData = new("testdata.json");

        [SetUp]
        public void SetUp()
        {
            browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(settings.GetValue<string>("url"));
            browser.WaitForPageToLoad();
        }

        [TearDown]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}