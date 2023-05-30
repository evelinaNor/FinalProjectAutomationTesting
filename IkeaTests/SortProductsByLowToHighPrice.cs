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
            Products.ForStudents.Open();
            Products.Filters.Sort.Toggle();
            Products.Filters.Sort.ByPriceLowToHigh();
            Products.Filters.Sort.Toggle();

            Assert.IsTrue(Products.ProductsAreSortedFromLowToHighPrice());
        }
    }
}
