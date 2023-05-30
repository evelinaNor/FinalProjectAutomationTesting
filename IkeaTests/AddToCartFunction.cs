﻿using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class AddToCartFunction : BaseTestWithChrome
    {
        [Test]
        public void AddToCartFunctionality()
        {
            string expectedQuantity = "2";

            Products.InteriorAndDecoration.PlantsAndFlowers.Open();
            Products.InteriorAndDecoration.PlantsAndFlowers.ClickOnFirstProduct();
            Products.ProductPage.ClickOnTheQantityInput();
            Products.ProductPage.EnterQuantity(expectedQuantity);
            Products.ProductPage.ClickOnAddToCartButton();
            Products.ProductPage.ClickOnContinueToTheCartLink();

            string actualQuantityOfTheCart = Cart.GetCartQuantity();

            Assert.AreEqual(expectedQuantity, actualQuantityOfTheCart);
        }
    }
}
