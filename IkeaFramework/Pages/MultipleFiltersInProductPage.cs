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
            string locatorOfProductList = "//*[contains(@class,'plp-product-list__products')]";
            List<IWebElement> products = Common.GetElements(locatorOfProductList);

            foreach (IWebElement product in products)
            {
                Common.ScrollUntilElementIsClickable(locatorOfProductList);

                string locator = "//span[@class='pip-header-section__description-text']";
                bool containsExpectedText = Common.WaitForTheElementThatContainsTextValue(expectedResult, locator);

                Driver.GetDriver().Navigate().Back();
                Thread.Sleep(5000);

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
