using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace IkeaFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static bool WaitForTheElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            return wait.Until(driver => driver.FindElement(By.XPath(locator)).Displayed);
        }
    }
}
