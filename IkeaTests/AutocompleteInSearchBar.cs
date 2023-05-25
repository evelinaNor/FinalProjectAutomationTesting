using IkeaFramework.Pages;
using IkeaTests.BaseTests;
using NUnit.Framework;

namespace IkeaTests
{
    internal class AutocompleteInSearchBar : BaseTestWithChrome
    {
        [SetUp]
        public void OpenMainPageAndCookiesAcception()
        {
            HomePage.Open();
            HomePage.AcceptCookies();
        }

        [Test]
        public void AutocompleteSuggestionsWithPartialSearchedItemInput()
        {
            string expectedResult = "mat";
            HomePageSearchBar.EnterSearchedItemPartialTitle(expectedResult);

            bool containsExpectedText = HomePageSearchBar.SuggestedListOfItemsContainPartialyInputedText(expectedResult);
            Assert.IsTrue(containsExpectedText);
        }
    }
}
