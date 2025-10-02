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

    }
}