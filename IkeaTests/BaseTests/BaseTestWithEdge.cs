using IkeaFramework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Driver.ShutdownDriver();
        }
    }
}
