using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTests
{
    internal class SortProductsByLowToHighPrice : BaseTestWithEdge
    {
        [SetUp]

        public void OpenMainPageAndCookiesAcception()
        {
            HomePage.Open();
            HomePage.AcceptCookies();
        }

        [Test]
        public void SortProductsFromLowToHighPrice()
        {
            ProductSortingByPricePage.OpenListOfProducts();
            ProductSortingByPricePage.ClickOnSortFilter();
            ProductSortingByPricePage.SelectPriceFromLowToHigh();

            Assert.IsTrue(ProductSortingByPricePage.ProductsAreSortedFromLowToHighPrice());

        }
    }
}
