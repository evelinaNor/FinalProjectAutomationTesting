using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class SortProductsByLowToHighPrice : BaseTestWithEdge
    {
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
