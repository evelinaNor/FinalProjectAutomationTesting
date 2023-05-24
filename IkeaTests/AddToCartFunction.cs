using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

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
