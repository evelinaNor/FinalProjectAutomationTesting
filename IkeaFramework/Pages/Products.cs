namespace IkeaFramework.Pages
{
    public class Products
    {
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

        public class InteriorAndDecoration
        {
            public class PlantsAndFlowers
            {
                public static void Open()
                {
                    Driver.NavigateToThePage("https://www.ikea.com/se/sv/cat/plantor-blommor-pp003/");
                }

                public static void ClickOnTheProduct()
                {
                    string locator = "(//*[@data-testid='plp-product-card'])[1]//a";
                    Common.Click(locator);
                }
            }
        }
    }
}
