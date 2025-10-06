using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    public class HomePage : Form
    {
        private IButton logo = ElementFactory.GetButton(By.ClassName("header-logo"), "noopCommerce Logo ");
        private ITextBox searchItem = ElementFactory.GetTextBox(By.Id("small-searchterms"), "Search store");
        private IButton SearchBtn = ElementFactory.GetButton(By.XPath("//*[@id=\"small-search-box-form\"]/button"), "Click Search Button");
        private ILabel featuredSection = ElementFactory.GetLabel(By.XPath("//strong[text()='Featured products']"), "Featured Products Section");
        private ILink firstFeaturedProduct = ElementFactory.GetLink(By.XPath("(//div[@class='product-item']//a[@href])[1]"), "First Featured Product");
        //private ILink secondFeaturedProduct = ElementFactory.GetLink(By.XPath("(//div[@class='product-item']//a[@href])[3]"), "First Featured Product");
        //private ILink thirdFeaturedProduct = ElementFactory.GetLink(By.XPath("(//div[@class='product-item']//a[@href])[5]"), "First Featured Product");
        //private ILink fourthFeaturedProduct = ElementFactory.GetLink(By.XPath("(//div[@class='product-item']//a[@href])[7]"), "First Featured Product");
        public HomePage() : base(By.ClassName("master-wrapper-page"), "Home Page")
        {
        }

        public void homePageTest()
        {
            logo.Click();
            Thread.Sleep(3000);
            
        }
        public void searchItemStore()
        {
            searchItem.SendKeys("Iphone 16");
            SearchBtn.Click();
            Thread.Sleep(3000);
        }

        public void featuredAndClickProduct()
        {
            var browser = AqualityServices.Browser;
            browser.ExecuteScript("arguments[0].scrollIntoView(true);", featuredSection.GetElement());
            featuredSection.State.WaitForDisplayed();
            firstFeaturedProduct.Click();
            //secondFeaturedProduct.Click();
            //thirdFeaturedProduct.Click();
            //fourthFeaturedProduct.Click();
            Thread.Sleep(1000);
        }

    }
}