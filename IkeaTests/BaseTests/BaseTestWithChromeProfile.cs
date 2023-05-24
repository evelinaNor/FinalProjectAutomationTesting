using IkeaFramework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithChromeProfile
    {
        [SetUp]
        public void SetUp()
        {
            string userDataDir = "C:\\Users\\Evelina\\AppData\\Local\\Google\\Chrome\\User Data";
            string profileDir = "Profile 6";
            Driver.InitializeDriver(userDataDir, profileDir);
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
