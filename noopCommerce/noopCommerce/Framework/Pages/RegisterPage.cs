using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    public class RegisterPage : Form
    {
        private IButton clickRegister = ElementFactory.GetButton(By.ClassName("ico-register"), "Register ");
        
        public RegisterPage() : base(By.ClassName("header-links"), "Register Page")
        {
        }

        public void registerPageTest()
        {
            clickRegister.Click();
            Thread.Sleep(1000);
        }

    }
}