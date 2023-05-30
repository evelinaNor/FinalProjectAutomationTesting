using OpenQA.Selenium;

namespace IkeaFramework.Pages
{
    public class LoginPage
    {
        public static void Navigate()
        {
            //Driver.NavigateToThePage("https://www.ikea.com/se/sv/profile/login?itm_campaign=logged-out&itm_element=slider&itm_content=login")
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/profile/login");
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@id='username']";
            Common.WaitForTheElementToBeVisible(locator);
            Common.SendKeys(locator, email);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='password']";
            Common.SendKeys(locator, password);
        }

        public static void ClickOnButtonContinue()
        {
            Cookie cookie = new Cookie("_cs_c", "1");
            Driver.GetDriver().Manage().Cookies.AddCookie(cookie);

            string locator = "//*[@id='root']/div/div[3]/div[1]/form/button";
            Common.Click(locator);
        }



        
    }
}
