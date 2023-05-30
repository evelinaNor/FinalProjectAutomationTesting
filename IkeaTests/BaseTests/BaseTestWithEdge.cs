using IkeaFramework;
using IkeaFramework.Pages;
using NUnit.Framework;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithEdge : BaseTest
    {
        [SetUp]
        public override void SetUp()
        {
            Driver.InitializeEdgeDriver();
            OpenHomePage();
        }
    }
}
