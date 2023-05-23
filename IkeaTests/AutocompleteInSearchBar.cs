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
            string expectedResult = "mat";
            HomePageSearchBar.EnterSearchedItemPartialTitle(expectedResult);

            bool containsExpectedText = HomePageSearchBar.SuggestedListOfItemsContainsPartialyInputedText(expectedResult);
            Assert.IsTrue(containsExpectedText);        
        }
    }
}
