﻿using OpenQA.Selenium;

namespace IkeaFramework.Pages
{
    public class LoginPage
    {
        public static void Naviagte()
        {
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/profile/login?itm_campaign=logged-out&itm_element=slider&itm_content=login");
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@id='username']";
            Common.WaitForTheElementToBeVisible(locator);
            Common.SendKeys(locator, email);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='password']";
            Common.SendKeys(locator, password);
        }

        public static void ClickOnButtonContinue()
        {
            Cookie cookie = new Cookie("_cs_c", "1");
            Driver.GetDriver().Manage().Cookies.AddCookie(cookie);

            string locator = "//*[@id='root']/div/div[3]/div[1]/form/button";
            Common.Click(locator);
        }

        public static bool UsersIconDisplayesUsersName(string usersName)
        {
            string locator = "//*[@id='loyalty-modal-button']/span";
            Common.WaitForTheElementThatContainsTextValue(locator, usersName);

            return true;
        }

        public static void Logout()
        {
            string iconLocator = "//*[@id='loyalty-modal-button']/span";
            Common.Click(iconLocator);

            string logOutButton = "//*[@id='header__button']/span";
            Common.WaitForTheElementToBeVisible(logOutButton);
            Common.Click(logOutButton);
        }
    }
}
