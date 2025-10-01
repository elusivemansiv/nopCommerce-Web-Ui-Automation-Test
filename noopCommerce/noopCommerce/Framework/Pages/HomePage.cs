using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    public class HomePage : Form
    {
        private IButton logo = ElementFactory.GetButton(By.ClassName("header-logo"), "noopCommerce Logo ");
        public HomePage() : base(By.ClassName("master-wrapper-page"), "Home Page")
        {
        }

        public void homePageTest()
        {
            logo.Click();
            Thread.Sleep(3000);
        }
  
    }
}