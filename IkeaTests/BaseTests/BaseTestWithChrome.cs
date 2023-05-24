using IkeaFramework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Driver.ShutdownDriver();
        }
    }
}
