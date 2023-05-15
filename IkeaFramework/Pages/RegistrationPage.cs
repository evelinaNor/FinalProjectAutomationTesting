using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            string locator = "//*[@id='family-signup-form-profileType-regular-option']";
            Common.WaitForTheElementToBeVisible(locator);
            Common.Click(locator);
        }

        public static void ClickOnCheckbox_NoSocialSecurityNumber()
        {
            string locator = "//*[@id='regular-signup-form-noSocialSecurityNumber']";
            Common.Click(locator);
        }

        public static void EnterDateOfBirth(string dateOfBirth)
        {
            string locator = "//*[@id='regular-signup-form-birthDate']";
            Common.SendKeys(locator, dateOfBirth);
        }

        public static void EnterName(string name)
        {
            string locator = "//*[@id='regular-signup-form-firstName']";
            Common.SendKeys(locator, name);
        }

        public static void EnterSurname(string surname)
        {
            string locator = "//*[@id='regular-signup-form-lastName']";
            Common.SendKeys(locator, surname);
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@id='regular-signup-form-email']";
            Common.SendKeys(locator, email);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='regular-signup-form-password']";
            Common.SendKeys(locator, password);
        }

        public static void ClickOnCheckbox_TermsAndConditions()
        {
            string locator = "//*[@id='regular-signup-form-acceptPrivacyPolicy']"; 
            Common.ScrollUntilElementIsClickable(locator);
            
        }

        public static void ClickOnGoFurtherButton()
        {
            string locator = "//*[@id='singup-form-submit-button']/span";
            Common.ScrollUntilElementIsClickable(locator);
        }

        public static bool CheckIfSideBannerIsDisplayed()
        {
            string locator = "//*[@id='root']/div/div[3]/div/form/div[22]/div[3]/div/div[2]";
            Common.WaitForTheElementToBeVisible(locator);

            return true;

        }
    }
}
