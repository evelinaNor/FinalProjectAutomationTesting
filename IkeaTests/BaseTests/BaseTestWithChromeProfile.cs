using IkeaFramework;
using NUnit.Framework;

namespace IkeaTests.BaseTests
{
    internal class BaseTestWithChromeProfile : BaseTest
    {
        [SetUp]
        public override void SetUp()
        {
            string userDataDir = "C:\\Users\\Evelina\\AppData\\Local\\Google\\Chrome\\User Data";
            string profileDir = "Profile 6";
            Driver.InitializeChromeDriverWithProfile(userDataDir, profileDir);
        }
    }
}
