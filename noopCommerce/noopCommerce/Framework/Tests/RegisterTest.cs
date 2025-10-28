using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using noopCommerce.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace noopCommerce.Framework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    internal class RegisterTest : BaseTest
    {
        [Test]
        [AllureSeverity]
        [AllureLink("Website", "")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to register to the wesbsite with valid data")]
       
        public void registerTest()
        {
            var registerPage = new RegisterPage();
            var registerFirstName = testData.GetValue<string>("First_Name");
            var registerLastName = testData.GetValue<string>("Last_Name");
            var registerEmail = testData.GetValue<string>("EmailInput");
            var registerPass = testData.GetValue<string>("PasswordInput");
            var confirmPass = testData.GetValue<string>("PasswordInput");

            registerPage.registerPageTest(registerFirstName, registerLastName, registerEmail, registerPass, confirmPass);

            AqualityServices.ConditionalWait.WaitFor(() => registerPage.State.WaitForDisplayed(), timeout: System.TimeSpan.FromSeconds(5));

            Assert.That(registerPage.GetSuccessMessage().Contains("Your registration completed"), "Registration failed — success message not found or incorrect");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to register to the wesbsite with same email again")]

        public void registerTest_2()
        {
            var registerPage = new RegisterPage();
            var registerFirstName = testData.GetValue<string>("First_Name");
            var registerLastName = testData.GetValue<string>("Last_Name");
            var registerEmail = testData.GetValue<string>("EmailInput");
            var registerPass = testData.GetValue<string>("PasswordInput");
            var confirmPass = testData.GetValue<string>("PasswordInput");

            registerPage.registerPageTest(registerFirstName, registerLastName, registerEmail, registerPass, confirmPass);

            AqualityServices.ConditionalWait.WaitFor(() => registerPage.State.WaitForDisplayed(), timeout: System.TimeSpan.FromSeconds(5));

            Assert.That(registerPage.GetFailMessage().Contains("The specified email already exists"), "Registration failed — success message not found or incorrect");
        }
    }
}