using IkeaFramework.Pages;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithChrome : BaseTest
    {
        internal override void SetUp()
        {
            base.SetUp();
            OpenHomePage();
        }
    }
}
