using IkeaFramework;
using NUnit.Framework;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithEdge : BaseTest
    {
        [SetUp]
        public override void SetUp()
        {
            Driver.InitializeEdgeDriver();
        }
    }
}
