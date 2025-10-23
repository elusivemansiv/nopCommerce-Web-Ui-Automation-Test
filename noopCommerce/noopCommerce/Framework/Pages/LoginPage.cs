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
        private IButton loginBtn = ElementFactory.GetButton(By.XPath("//div[@class='buttons']//button[@class='button-1 login-button']"), "Click Login");

        public LoginPage() : base(By.ClassName("header-links"), "Login Page")
        {
        }

        public void loginPageValidTest()
        {
            clickLogin.Click();
            email.SendKeys("test@gmail.com");
            Password.SendKeys("123456");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageInValidEmailTest()
        {
            clickLogin.Click();
            email.SendKeys("testing@gmail.com");
            Password.SendKeys("123456");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageInValidPassTest()
        {
            clickLogin.Click();
            email.SendKeys("testing@gmail.com");
            Password.SendKeys("111111");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageNoEmailTest()
        {
            clickLogin.Click();
            email.SendKeys("");
            Password.SendKeys("123456");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageNoPassword()
        {
            clickLogin.Click();
            email.SendKeys("testing@gmail.com");
            Password.SendKeys("");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageNoDataTest()
        {
            clickLogin.Click();
            loginBtn.Click();
            Thread.Sleep(1000);
        }
    }
}