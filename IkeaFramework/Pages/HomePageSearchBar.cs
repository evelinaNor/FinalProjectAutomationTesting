using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaFramework.Pages
{
    public class HomePageSearchBar
    {
        public static void ClickOnTheSearchBar()
        {
            string locator = "//*[@data-id='box-mount']";
            Common.Click(locator);
        }

        public static void EnterSearchedItemPartialTitle(string expectedResult)
        {
            string locator = "";
            Common.SendKeys(locator, expectedResult);
        }

        public static object SuggestedListOfItemsContainsPartialyInputedText(string expectedResult)
        {
            throw new NotImplementedException();
        }
    }
}
