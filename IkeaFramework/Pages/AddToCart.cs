
namespace IkeaFramework.Pages
{
    public class AddToCart
    {
        public static void OpenProductListPage()
        {
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/cat/plantor-blommor-pp003/");
        }

        public static void ClickOnTheProduct()
        {
            string locator = "(//*[@data-testid='plp-product-card'])[1]//a";
            Common.Click(locator);
        }

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

        public static void ClickOnContinueToTheCartLink()
        {
            string locator = "//*[@data-testid='go-to-cart']";
            Common.WaitForTheElementToBeVisible(locator);
            Common.Click(locator);
        }

        public static string GetCartQuantity()
        {
            string locator = "//*[@class='cart-ingka-quantity-stepper__input']";
            Common.WaitForTheElementToBeVisible(locator);
            return Common.GetElementAttributeValue(locator, "value");
        }

        public static void ClickOnTheQantityInput()
        {
            string locator = "//*[@id='pip-buy-module-content']/div[4]/div/div/div/div/div/input";
            Common.Click(locator);
        }
    }
}
