using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
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
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
                wait.Until(driver => driver.FindElement(By.XPath(locator)));

                return true;
            }

            catch (NoSuchElementException)
            {
                return false;
            }     
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static void ScrollUntilElementIsClickable(string locator)
        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = 20;
            int currentTry = 0;

            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch (Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0, 200)");
                        currentTry++;
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }
    }
}
