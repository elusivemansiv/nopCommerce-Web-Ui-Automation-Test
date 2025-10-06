using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    internal class ProductPage : Form
    {
        private IComboBox selectProcessor = ElementFactory.GetComboBox(By.Id("product_attribute_1"), "Processor Select Menu");
        private IComboBox selectRam = ElementFactory.GetComboBox(By.Id("product_attribute_2"), "Select RAM");
        private IButton hdd = ElementFactory.GetButton(By.Id("product_attribute_3_7"), "HDD Option");
        private IButton os = ElementFactory.GetButton(By.Id("product_attribute_4_9"), "OS Option");
        private IButton softwareCheckbox = ElementFactory.GetButton(By.Id("product_attribute_5_11"), "Software Checkbox");
        private IButton addToCartBtn = ElementFactory.GetButton(By.XPath("//*[@id=\"add-to-cart-button-1\"]"), "Add To Cart Button");
        public ProductPage() : base(By.ClassName("master-wrapper-content"), "Product Page")
        {
        }
        public void ClickAddToCart(string processorValue, string ramValue)
        {
            selectProcessor.SelectByValue(processorValue);
            selectRam.SelectByValue(ramValue);
            hdd.Click();
            os.Click();
            softwareCheckbox.Click();

            addToCartBtn.Click();
            Thread.Sleep(1000);
        }

    }
}
