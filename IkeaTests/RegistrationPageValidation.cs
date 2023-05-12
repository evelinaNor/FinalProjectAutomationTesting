using IkeaFramework;
using IkeaFramework.Pages;
using NUnit.Framework;
using System.Security.AccessControl;

namespace IkeaTests
{
    internal class RegistrationPageValidation
    {
       [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            HomePage.Open();
            HomePage.AcceptCookies();    
        } 

      [Test] 
     public void FillFormWithValidData() 
        {

            RegistrationPage.Navigate();
            RegistrationPage.ClickRadioButton_No();
            RegistrationPage.ClickOnCheckbox_NoSocialSecurityNumber();


        }
    }
}
