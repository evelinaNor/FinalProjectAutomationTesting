using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace IkeaFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        public static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static bool WaitForTheElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)));

            return true;
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

        internal static bool WaitForTheElementThatContainsTextValue(string locator, string expectedText)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(driver => driver.FindElement(By.XPath(locator)));

            return element.Text.Contains(expectedText);
        }

        internal static string GetElementAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }
    }
}
