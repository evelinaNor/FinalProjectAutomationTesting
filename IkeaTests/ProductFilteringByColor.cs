﻿using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class ProductFilteringByColor : BaseTestWithChrome
    {
        [SetUp]
        public void OpenMainPageAndCookiesAcception()
        {
            HomePage.Open();
            HomePage.AcceptCookies();
        }

        [Test]
        public void ProductColorFilterSelectionSortsProductsAccordingly()
        {
            string expectedResult = "svart";

            ProductFilteringByColorPage.OpenProductListPage();
            ProductFilteringByColorPage.ToggleTheColorFilter();
            ProductFilteringByColorPage.SelectColor(expectedResult);

            bool containsExpectedText = ProductFilteringByColorPage.ProductHeaderSectionContainsColorText(expectedResult);
            Assert.IsTrue(containsExpectedText);
        }
    }
}
