using IkeaFramework;
using NUnit.Framework;
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
            Driver.ShutdownDriver();
        }
    }
}
