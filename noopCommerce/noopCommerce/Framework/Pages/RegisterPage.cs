using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;

namespace noopCommerce.Framework.Pages
{
    public class RegisterPage : Form
    {
        private IButton clickRegister = ElementFactory.GetButton(By.ClassName("ico-register"), "Register");
        private IButton gender = ElementFactory.GetButton(By.Id("gender-male"), "Male radio button");
        private ITextBox FirstName = ElementFactory.GetTextBox(By.Id("FirstName"), "First name");
        private ITextBox LastName = ElementFactory.GetTextBox(By.Id("LastName"), "Last name");
        private ITextBox Email = ElementFactory.GetTextBox(By.Id("Email"), "Email");
        private ITextBox Password = ElementFactory.GetTextBox(By.Id("Password"), "Password");
        private ITextBox confirmPassword = ElementFactory.GetTextBox(By.Id("ConfirmPassword"), "Confirm password");
        private IButton submitBtn = ElementFactory.GetButton(By.Id("register-button"), "Register button");
        private ILabel successmsg = ElementFactory.GetLabel(By.XPath("//div[@class='result']"), "Register success message");
        private ILabel validationmsg = ElementFactory.GetLabel(By.XPath("//div[@class='message-error validation-summary-errors']//li[text()='The specified email already exists']"), "Register VAlidation Message");

        public RegisterPage() : base(By.ClassName("header-links"), "Register Page") { }

        public void registerPageTest(string firstname, string lastname, string email, string password, string confirmPass)
        {
            clickRegister.Click();
            Thread.Sleep(1000);
            gender.Click();
            FirstName.SendKeys(firstname);
            LastName.SendKeys(lastname);
            Email.SendKeys(email);
            Password.SendKeys(password);
            confirmPassword.SendKeys(confirmPass);
            submitBtn.Click();
            Thread.Sleep(1000);
        }

        public string GetSuccessMessage()
        {
            return successmsg.GetText();
        }

        public string GetFailMessage()
        {
            return validationmsg.GetText();
        }
    }
}
