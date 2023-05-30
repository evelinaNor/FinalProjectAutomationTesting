using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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

        public static bool ProductsAreSortedFromLowToHighPrice()
        {
            string productPriceLocator = "//*[@class='pip-price__integer']";
            Thread.Sleep(500);

            List<IWebElement> prices = Common.GetElements(productPriceLocator);

            List<double> allPrices = new List<double>();

            foreach (IWebElement price in prices)
            {
                string priceText = Common.GetElementText(price);
                double priceToDouble = double.Parse(priceText);
                allPrices.Add(priceToDouble);
            }

            bool isSorted = Common.IsListSortedAscending(allPrices);
            return isSorted;
        }

        public class Filters
        {
            public class Color
            {
                public static void Toggle()
                {
                    string locator = "//*[@aria-label='Visa Färg']";
                    Common.Click(locator);
                }

                public static void SelectColor(string color)
                {
                    string locator = $"//*[@id='{color}']";
                    Common.WaitForTheElementToBeVisible(locator);
                    Common.Click(locator);
                }
            }

            public class Sort
            {
                public static void Toggle()
                {
                    string locator = "//*[@aria-label='Visa modal för sorteringsalternativ']";
                    Common.Click(locator);
                }

                public static void ByPriceLowToHigh()
                {
                    string locator = "//*[@id='content']/div/div/div/div/div/div[2]/div[4]/div/fieldset/label[2]/span[2]";
                    Common.WaitForTheElementToBeVisible(locator);
                    Common.Click(locator);
                }
            }
        }

        public class ForStudents
        {
            public static void Open()
            {
                Driver.NavigateToThePage("https://www.ikea.com/se/sv/search/?group=Allt%20f%C3%B6r%20studenten");
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
