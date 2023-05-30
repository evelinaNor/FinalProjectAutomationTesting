using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace IkeaFramework.Pages
{
    public class Products
    {
        public static bool EachProductHeaderSectionContainsColorText(string expectedResult)
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

        public class Filters
        {
            public class Color
            {
                public static void Toggle()
                {
                    string locator = "/html/body/main/div/div/div[5]/div[1]/div/div[1]/div[2]/div/button[4]";
                    Common.Click(locator);
                }

                public static void SelectColor(string color)
                {
                    string locator = $"//*[@id='{color}']";

                    Common.WaitForTheElementToBeVisible(locator);
                    Common.Click(locator);
                }
            }
        }

        public class ProductPage
        {
            public static void EnterQuantity(string quantity)
            {
                string locator = "//*[@id='pip-buy-module-content']/div[4]/div/div/div/div/div/input";
                Common.SendKeys(locator, quantity);
            }

            public static void ClickOnAddToCartButton()
            {
                string locator = "//*[@id='pip-buy-module-content']/div[4]/div/div/div/button/span/span";
                Common.Click(locator);
            }

            public static void ClickOnTheQantityInput()
            {
                string locator = "//*[@id='pip-buy-module-content']/div[4]/div/div/div/div/div/input";
                Common.Click(locator);
            }

            public static void ClickOnContinueToTheCartLink()
            {
                string locator = "//*[@data-testid='go-to-cart']";
                Common.WaitForTheElementToBeVisible(locator);
                Common.Click(locator);
            }
        }

        public class Furniture
        {
            public class Tables
            {
                public static void Open()
                {
                    Driver.NavigateToThePage("https://www.ikea.com/se/sv/cat/bord-fu004/");
                }
            }
        }

        public class InteriorAndDecoration
        {
            public class PlantsAndFlowers
            {
                public static void Open()
                {
                    Driver.NavigateToThePage("https://www.ikea.com/se/sv/cat/plantor-blommor-pp003/");
                }

                public static void ClickOnFirstProduct()
                {
                    string locator = "(//*[@data-testid='plp-product-card'])[1]//a";
                    Common.Click(locator);
                }
            }
        }
    }
}
