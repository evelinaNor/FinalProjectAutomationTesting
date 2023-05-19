using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IkeaTests
{
    internal class MultipleFiltersInProductDisplayPage : BaseTest
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

            MultipleFiltersInProductPage.OpenProductListPage();
            MultipleFiltersInProductPage.ClickOnTheColorFilter();
            Thread.Sleep(3000);
            MultipleFiltersInProductPage.SelectColorFilter(expectedResult);
            MultipleFiltersInProductPage.ClickOnTheColorFilterAgainToCloseIt();
            bool containsExpectedText = MultipleFiltersInProductPage.ProductHeaderSectionContainsColorText(expectedResult);
            Assert.IsTrue(containsExpectedText);

        }

    }
}
