using IkeaFramework;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using IkeaFramework.Pages;

namespace IkeaTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public virtual void SetUp()
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

        internal void OpenHomePage()
        {
            HomePage.Open();
            HomePage.AcceptCookies();
        }
    }
}
