using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace IkeaFramework.Pages
{
    public class SearchBar
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

        public static bool SuggestedListOfItemsContainPartialyInputedText(string expectedResult)
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
                    string errorMessage = $"Doesn't contain {expectedResult} text: actual text - {actualText}";
                    throw new Exception(errorMessage);
                }
            }

            return true;
        }
    }
}
