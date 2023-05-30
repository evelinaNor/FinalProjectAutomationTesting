
namespace IkeaFramework.Pages
{
    public class HomePage
    {
        public static void Open()
        {
            Driver.NavigateToThePage("https://www.ikea.com/se/sv/");
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
