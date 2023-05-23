using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaFramework.Pages
{
    public class ProductSortingByPricePage
    {    
        public static void OpenListOfProducts()
        {
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/search/?group=Allt%20f%C3%B6r%20studenten");
        }

        public static void ClickOnSortFilter()
        {
            string locator = "//*[@id='content']/div/div/div/div/div/div[2]/div/button[1]";
            Common.Click(locator);
        }

        public static void SelectPriceFromLowToHigh()
        {
            string locator = "//*[@id='content']/div/div/div/div/div/div[2]/div[4]/div/fieldset/label[2]/span[2]";
            Common.WaitForTheElementToBeVisible(locator);
            Common.Click(locator);

            string closeFilterTableLocator = "//*[@id='content']/div/div/div/div/div/div[2]/div/button[1]";
            Common.Click(closeFilterTableLocator);
        }

        public static bool ProductsAreSortedFromLowToHighPrice()
        {
            string locatorOfProductList = "//*[@id='product-list']";
            List<IWebElement> products = Common.GetElements(locatorOfProductList);

            List<double> prices = new List<double>();

            foreach (IWebElement product in products)
            {
                string productPriceLocator = "//*[@class='plp-price__integer']";

                Common.WaitForTheElementToBeVisible(productPriceLocator);
                string priceText = Common.GetElementText(productPriceLocator);
                double price = double.Parse(priceText);
                prices.Add(price);
            }

            bool isSorted = IsListSortedAscending(prices);
            return isSorted;
        }

        private static bool IsListSortedAscending(List<double> prices)
        {
            for (int i = 1; i < prices.Count; i++)
            {
                if (prices[i] < prices[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
