using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.WebAuthn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaFramework.Pages
{
    public class HomePageSearchBar
    {
        public static void ClickOnTheSearchBar()
        {
            string locator = "//*[@data-id='box-mount']";
            Common.Click(locator);
        }

        public static void EnterSearchedItemPartialTitle(string expectedResult)
        {
            string locator = "//*[@id='ikea-search-input']";
            Common.SendKeys(locator, expectedResult);
        }

        public static bool SuggestedListOfItemsContainsPartialyInputedText(string expectedResult)
        {
            string locatorOfSuggestions = "//*[@id='search-suggestions']//*[contains(@class,'universal-item__title with-autocomplete-icon')]";
            Common.WaitForTheElementToBeVisible(locatorOfSuggestions);

            List<IWebElement> products = Common.GetElements(locatorOfSuggestions);

            foreach (IWebElement product in products)
            {
                string locator = "//*[@id='search-suggestions']/li/a";
                string actualText = Common.GetElementAttributeValue(locator,"aria-label");
                if (!actualText.Contains(expectedResult))
                {
                    string errorMessage = $"Doesn't contain {expectedResult} text";
                    throw new Exception(errorMessage);
                }
            }

            return true;
        }
    }
}
