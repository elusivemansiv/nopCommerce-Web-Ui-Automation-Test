using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    public class LoginPage : Form
    {
        private IButton clickLogin = ElementFactory.GetButton(By.ClassName("ico-login"), "Login");
        private ITextBox email = ElementFactory.GetTextBox(By.Id("Email"), "Email");
        private ITextBox Password = ElementFactory.GetTextBox(By.Id("Password"), "Password");
        private IButton loginBtn = ElementFactory.GetButton(By.XPath("//*[@id=\"main\"]/div/div/div/div[2]/div[1]/div[2]/form/div[3]/button"), "Click Login");

        public LoginPage() : base(By.ClassName("header-links"), "Login Page")
        {
        }

        public void loginPageTest()
        {
            clickLogin.Click();
            email.SendKeys("test@gmail.com");
            Password.SendKeys("123456");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

    }
}