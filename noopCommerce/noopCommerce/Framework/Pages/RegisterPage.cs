using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    public class RegisterPage : Form
    {
        private IButton clickRegister = ElementFactory.GetButton(By.ClassName("ico-register"), "Register ");
        private IButton gender = ElementFactory.GetButton(By.Id("gender-male"), "Male radio button");
        private ITextBox firstName = ElementFactory.GetTextBox(By.Id("FirstName"), "First name is required.");
        private ITextBox lastName = ElementFactory.GetTextBox(By.Id("LastName"), "LastName is required.");
        private ITextBox email = ElementFactory.GetTextBox(By.Id("Email"), "Email is required.");
        private ITextBox password = ElementFactory.GetTextBox(By.Id("Password"), "Password is required.");
        private ITextBox confirmPassword = ElementFactory.GetTextBox(By.Id("ConfirmPassword"), "ConfirmPassword is required.");
        private IButton submitBtn = ElementFactory.GetButton(By.Id("register-button"), "click register-button");
        public RegisterPage() : base(By.ClassName("header-links"), "Register Page")
        {
        }

        public void registerPageTest()
        {
            clickRegister.Click();
            Thread.Sleep(1000);
            gender.Click();
            firstName.SendKeys("Mr.");
            lastName.SendKeys("Test");
            password.SendKeys("123456");
            email.SendKeys("test@gmail.com");
            confirmPassword.SendKeys("123456");
            submitBtn.Click();
            Thread.Sleep(1000);
        }

    }
}