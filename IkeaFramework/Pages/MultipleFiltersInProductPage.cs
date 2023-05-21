using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IkeaFramework.Pages
{
    public class MultipleFiltersInProductPage
    {
        public static void ClickOnTheColorFilter()
        {
            string locator = "/html/body/main/div/div/div[5]/div[1]/div/div[1]/div[2]/div/button[4]";
            Common.Click(locator);
        }

        public static void ClickOnTheColorFilterAgainToCloseIt()
        {
            string locator = "/html/body/main/div/div/div[5]/div[1]/div/div[1]/div[2]/div/button[4]";
            Common.Click(locator);
        }

        public static void OpenProductListPage()
        {
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/cat/bord-fu004/");
        }

        public static bool ProductHeaderSectionContainsColorText(string expectedResult)
        {
            string locatorOfProductList = "//*[@data-testid='plp-product-card']";
            List<IWebElement> products = Common.GetElements(locatorOfProductList);

            foreach (IWebElement product in products)
            {
                Actions.CtrlShiftClickOnElement(product);

                string locator = "//*[@id='pip-buy-module-content']//*[@class='pip-header-section__description-text']";
                bool containsExpectedText = Common.GetElementsTextValueInTheNewTab(expectedResult, locator);
                Common.CloseTab();
                Common.SwitchToDefaultContent();

                if (!containsExpectedText)
                    return false;
            }

            return true;
        }

        public static void SelectColorFilter(string expectedResult)
        {
            string locator = $"//*[@id='{expectedResult}']";
            Common.Click(locator);
        }
    }
}
