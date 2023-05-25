using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class AddToCartFunction : BaseTestWithChrome
    {
        [SetUp]
        public void OpenMainPageAndCookiesAcception()
        {
            HomePage.Open();
            HomePage.AcceptCookies();
        }

        [Test]
        public void AddToCartFunctionality()
        {
            string expectedQuantity = "2";

            AddToCart.OpenProductListPage();
            AddToCart.ClickOnTheProduct();
            AddToCart.ClickOnTheQantityInput();
            AddToCart.EnterQuantity(expectedQuantity);
            AddToCart.ClickOnAddToCartButton();
            AddToCart.ClickOnContinueToTheCartLink();

            string actualQuantityOfTheCart = AddToCart.GetCartQuantity();

            Assert.AreEqual(expectedQuantity, actualQuantityOfTheCart);
        }
    }
}
