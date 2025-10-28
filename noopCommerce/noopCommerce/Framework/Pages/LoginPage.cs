using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    public class LoginPage : Form
    {
        private IButton clickLogin = ElementFactory.GetButton(By.ClassName("ico-login"), "Login");
        private ITextBox Email = ElementFactory.GetTextBox(By.Id("Email"), "Email");
        private ITextBox Password = ElementFactory.GetTextBox(By.Id("Password"), "Password");
        private IButton loginBtn = ElementFactory.GetButton(By.XPath("//div[@class='buttons']//button[@class='button-1 login-button']"), "Click Login");
        private ILabel failmsg = ElementFactory.GetLabel(By.XPath("//div[@class='message-error validation-summary-errors']"), "Login Fail Message");
        private ILabel validationmsg = ElementFactory.GetLabel(By.XPath("//span[@class='field-validation-error']"),"validation error msg");
        public LoginPage() : base(By.ClassName("header-links"), "Login Page")
        {
        }

        public void loginPageValidTest(string email, string password)
        {
            clickLogin.Click();
            Email.SendKeys(email);
            Password.SendKeys(password);
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageInValidEmailTest()
        {
            clickLogin.Click();
            Email.SendKeys("testing@gmail.com");
            Password.SendKeys("123456");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageInValidPassTest()
        {
            clickLogin.Click();
            Email.SendKeys("testing@gmail.com");
            Password.SendKeys("111111");
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageNoEmailTest(string password)
        {
            clickLogin.Click();
            Email.SendKeys("");
            Password.SendKeys(password);
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void loginPageNoPassword(string email)
        {
            clickLogin.Click();
            Email.SendKeys(email);
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

        public string GetUnSuccessMessage()
        {
            return failmsg.GetText();
        }

        public string GetFormValidationMessage()
        {
            return validationmsg.GetText();
        }
    }
}