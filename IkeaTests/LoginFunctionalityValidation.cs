using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTests
{
    internal class LoginFunctionalityValidation : BaseTestWithChromeProfile
    {
        [SetUp]
        public void OpenMainPageAndCookiesAcception()
        {
            HomePage.Open();
            HomePage.AcceptCookies();
        }

        [Test]
        public void LoginSuccessfullyWithEmail()
        {
            LoginPage.Naviagte();

            string email = "karolka789456@gmail.com";
            string password = "Slaptazodis123";
            string expectedUserName = "Karolina";

       
            LoginPage.EnterEmail(email);
            LoginPage.EnterPassword(password);
            LoginPage.ClickOnButtonContinue();

            Assert.IsTrue(LoginPage.UsersIconDisplayesUsersName(expectedUserName));

        }
    }
}
