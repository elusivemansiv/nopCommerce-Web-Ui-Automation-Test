using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Framework;

namespace noopCommerce.Framework.Tests
{
    internal class CartTest : BaseTest
    {
        [Test]
        public void ViewProductAndCartTest()
        {
            var itemPage = new HomePage();
            itemPage.featuredAndClickFirstProduct();
            AqualityServices.Browser.WaitForPageToLoad();

            var productPage = new ProductPage();
            productPage.ClickAddToCart("2", "5");

        }

        [Test]
        public void ViewMAcProductAndCartTest()
        {
            var itemPage = new HomePage();
            itemPage.featuredAndClickSecondProduct();
            AqualityServices.Browser.WaitForPageToLoad();
            var productPage = new ProductPage();
            productPage.ClickAddToCartMac("1");
        }
    }
}
