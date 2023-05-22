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
    internal class AutocompleteInSearchBar : BaseTest
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
            string expectedResult = "bo";

            HomePageSearchBar.ClickOnTheSearchBar();
            HomePageSearchBar.EnterSearchedItemPartialTitle(expectedResult);

            Assert.Equals(expectedResult, HomePageSearchBar.SuggestedListOfItemsContainsPartialyInputedText(expectedResult));
            
        }

    }
}
