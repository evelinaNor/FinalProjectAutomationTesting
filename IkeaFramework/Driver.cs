using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Edge;


namespace IkeaFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void InitializeChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-size=1920,1080");
            driver.Value = new ChromeDriver(options);
        }

        public static void InitializeEdgeDriver()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("--window-size=1920,1080");
            driver.Value = new EdgeDriver(options);
        }

        public static void InitializeDriver(string userDataDir, string profileDir)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userDataDir}");
            options.AddArgument($"--profile-directory={profileDir}");
            driver.Value = new ChromeDriver(options);
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        internal static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Value.Quit();
        }

        internal static void NavigateToThePage(string url)
        {
            driver.Value.Url = url;
        }
    }
}
