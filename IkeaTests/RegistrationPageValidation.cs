using IkeaFramework;
using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;
using System.Security.AccessControl;

namespace IkeaTests
{
    internal class RegistrationPageValidation : BaseTest
    {
       [SetUp]
        public void OpenMainPageAndCookiesAcception()
        {
            HomePage.Open();
            HomePage.AcceptCookies();    
        } 

      [Test] 
     public void FillFormWithValidData() 
        {
            

            RegistrationPage.Navigate();
            RegistrationPage.ClickRadioButton_No();
            RegistrationPage.ClickOnCheckbox_NoSocialSecurityNumber();
          

            string dateOfBirth = "1994 05 05";
            string name = "Evelina";
            string surname = "Norvilaite";
            string email = "eva@gmail.com";
            string password = "Slaptazodis123";

            RegistrationPage.EnterDateOfBirth(dateOfBirth);
            RegistrationPage.EnterName(name);
            RegistrationPage.EnterSurname(surname);
            RegistrationPage.EnterEmail(email);
            RegistrationPage.EnterPassword(password);
            RegistrationPage.ClickOnCheckbox_TermsAndConditions();
            RegistrationPage.ClickOnGoFurtherButton();

           Assert.IsTrue(RegistrationPage.SideBannerIsDisplayed());
        }
    }
}
