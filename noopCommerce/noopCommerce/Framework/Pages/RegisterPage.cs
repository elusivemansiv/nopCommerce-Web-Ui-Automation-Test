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
<<<<<<< HEAD
        private ITextBox FirstName = ElementFactory.GetTextBox(By.Id("FirstName"), "First name is required.");
        private ITextBox LastName = ElementFactory.GetTextBox(By.Id("LastName"), "LastName is required.");
        private ITextBox Email = ElementFactory.GetTextBox(By.Id("Email"), "Email is required.");
        private ITextBox Password = ElementFactory.GetTextBox(By.Id("Password"), "Password is required.");
=======
        private ITextBox firstName = ElementFactory.GetTextBox(By.Id("FirstName"), "First name is required.");
        private ITextBox lastName = ElementFactory.GetTextBox(By.Id("LastName"), "LastName is required.");
        private ITextBox email = ElementFactory.GetTextBox(By.Id("Email"), "Email is required.");
        private ITextBox password = ElementFactory.GetTextBox(By.Id("Password"), "Password is required.");
>>>>>>> 7b244fa0232d43dfbcb49c24a833e8775ca06f59
        private ITextBox confirmPassword = ElementFactory.GetTextBox(By.Id("ConfirmPassword"), "ConfirmPassword is required.");
        private IButton submitBtn = ElementFactory.GetButton(By.Id("register-button"), "click register-button");
        private ILabel successmsg = ElementFactory.GetLabel(By.XPath("//div[@class='result']"), "Register Success Message");
        private ILabel validationmsg = ElementFactory.GetLabel(By.XPath("//div[@class='message-error validation-summary-errors']//li[text()='The specified email already exists']"), "Register VAlidation Message");


        //div[@class='buttons']//a[@class='button-1 register-continue-button']
        public RegisterPage() : base(By.ClassName("header-links"), "Register Page")
        {
        }

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