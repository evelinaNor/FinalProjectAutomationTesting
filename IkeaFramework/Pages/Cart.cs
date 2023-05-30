namespace IkeaFramework.Pages
{
    public class Cart
    {
        public static string GetCartQuantity()
        {
            string locator = "//*[@class='cart-ingka-quantity-stepper__input']";
            Common.WaitForTheElementToBeVisible(locator);
            return Common.GetElementAttributeValue(locator, "value");
        }
    }
}
