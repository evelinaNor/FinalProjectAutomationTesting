using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class LoginFunctionalityValidation : BaseTestWithChromeProfile
    {
        [SetUp]
        public void OpenMainPageAndCookiesAcception()
        {
            HomePage.Open();
        }

        [Test]
        public void LoginSuccessfullyWithEmail()
        {
            LoginPage.Navigate();

            string email = "karolka789456@gmail.com";
            string password = "Slaptazodis123";
            string expectedUserName = "Karolina";

            LoginPage.EnterEmail(email);
            LoginPage.EnterPassword(password);
            LoginPage.ClickOnButtonContinue();
    
            Assert.IsTrue(HomePage.UsersIconDisplayesUsersName(expectedUserName));
            HomePage.Logout();
        }
    }
}
