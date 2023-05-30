using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class AutocompleteInSearchBar : BaseTestWithChrome
    {
        [Test]
        public void AutocompleteSuggestionsWithPartialSearchedItemInput()
        {
            string expectedResult = "mat";
            SearchBar.EnterSearchedItemPartialTitle(expectedResult);

            bool containsExpectedText = SearchBar.SuggestedListOfItemsContainPartialyInputedText(expectedResult);
            Assert.IsTrue(containsExpectedText);
        }
    }
}
