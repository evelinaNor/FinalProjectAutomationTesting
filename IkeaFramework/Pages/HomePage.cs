using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaFramework.Pages
{
    public class HomePage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.ikea.com/se/sv/");
            Cookie cookie = new Cookie("_cs_c", "1");
            Driver.GetDriver().Manage().Cookies.AddCookie(cookie);
            //Driver.GetDriver().Manage().Cookies.DeleteAllCookies();
        }

        public static void AcceptCookies()
        {
            string cookiesWindow = "//*[@id='onetrust-group-container']";
            Common.WaitForTheElementToBeVisible(cookiesWindow);

            string acceptButton = "//*[@id='onetrust-accept-btn-handler']";
            Common.Click(acceptButton);
        }

    }
}
