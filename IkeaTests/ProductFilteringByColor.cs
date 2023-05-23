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
    internal class ProductFilteringByColor : BaseTest
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
            ProductFilteringByColorPage.SelectColorInTheFilter(expectedResult);

            bool containsExpectedText = ProductFilteringByColorPage.ProductHeaderSectionContainsColorText(expectedResult);
            Assert.IsTrue(containsExpectedText);
        }
    }
}
