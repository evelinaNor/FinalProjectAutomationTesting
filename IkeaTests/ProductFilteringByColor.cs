using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class ProductFilteringByColor : BaseTestWithChrome
    {
        [Test]
        public void ProductColorFilterSelectionSortsProductsAccordingly()
        {
            string expectedResult = "svart";

            Products.Furniture.Tables.Open();
            Products.Filters.Color.Toggle();
            Products.Filters.Color.SelectColor(expectedResult);
            Products.Filters.Color.Toggle();

            bool containsExpectedText = Products.EachProductHeaderSectionContainsColorText(expectedResult);
            Assert.IsTrue(containsExpectedText);
        }
    }
}
