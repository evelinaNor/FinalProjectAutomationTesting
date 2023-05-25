using IkeaFramework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithChrome
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeChromeDriver();
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
