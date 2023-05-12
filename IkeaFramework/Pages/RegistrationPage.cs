using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaFramework.Pages
{
    public class RegistrationPage
    {
        public static void Navigate()
        {
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/profile/signup/");
        }

        public static void ClickRadioButton_No()
        {
            string locator = "//*[@id='regular-signup-form-profileType-regular-option']";
            Common.WaitForTheElementToBeVisible(locator);
            Common.Click(locator);
        }

        public static void ClickOnCheckbox_NoSocialSecurityNumber()
        {
            string locator = "//*[@id='regular-signup-form-noSocialSecurityNumber']";
            Common.Click(locator);
        }
    }
}
