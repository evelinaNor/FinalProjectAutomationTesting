using IkeaFramework.Pages;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithChrome : BaseTest
    {
        public override void SetUp()
        {
            base.SetUp();
            OpenHomePage();
        }
    }
}
