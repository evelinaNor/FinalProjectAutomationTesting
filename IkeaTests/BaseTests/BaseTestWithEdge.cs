using IkeaFramework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithEdge
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeEdgeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
            Driver.ShutdownDriver();
        }
    }
}
