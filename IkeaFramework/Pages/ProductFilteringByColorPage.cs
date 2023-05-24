using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace IkeaFramework.Pages
{
    public class ProductFilteringByColorPage
    {
        public static void OpenProductListPage()
        {
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/cat/bord-fu004/");
        }
        public static void ToggleTheColorFilter()
        {
            string locator = "/html/body/main/div/div/div[5]/div[1]/div/div[1]/div[2]/div/button[4]";
            Common.Click(locator);
        }
        public static void SelectColor(string expectedResult)
        {
            string locator = $"//*[@id='{expectedResult}']";
            string toggleFilterLocator = "/html/body/main/div/div/div[5]/div[1]/div/div[1]/div[2]/div/button[4]";

            Common.WaitForTheElementToBeVisible(locator);
            Common.Click(locator);
            Common.Click(toggleFilterLocator);
        }
        public static void ClickOnTheColorFilterAgainToCloseIt()
        {
            string locator = "/html/body/main/div/div/div[5]/div[1]/div/div[1]/div[2]/div/button[4]";
            Common.Click(locator);
        }

        public static bool ProductHeaderSectionContainsColorText(string expectedResult)
        {
            string parentWindowHandle = Common.GetWindowHandles().First();

            string locatorOfProductList = "//*[@data-testid='plp-product-card']";
            List<IWebElement> products = Common.GetElements(locatorOfProductList);

            foreach (IWebElement product in products)
            {
                Common.CtrlShiftClickOnElement(product);
                Common.SwitchToWindowByHandle(Common.GetWindowHandles().Last());

                string locator = "//*[@id='pip-buy-module-content']//*[@class='pip-header-section__description-text']";
                string actualText = Common.GetElementText(locator);
                if (!actualText.Contains(expectedResult))
                {
                    return false;
                }

                Common.CloseTab();
                Common.SwitchToWindowByHandle(parentWindowHandle);
            }

            return true;
        }
    }
}
