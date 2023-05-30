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

            Products.InteriorAndDecoration.PlantsAndFlowers.Open();
            Products.InteriorAndDecoration.PlantsAndFlowers.ClickOnTheProduct();
            Products.ProductPage.ClickOnTheQantityInput();
            Products.ProductPage.EnterQuantity(expectedQuantity);
            Products.ProductPage.ClickOnAddToCartButton();
            Products.ProductPage.ClickOnContinueToTheCartLink();

            string actualQuantityOfTheCart = Cart.GetCartQuantity();

            Assert.AreEqual(expectedQuantity, actualQuantityOfTheCart);
        }
    }
}
