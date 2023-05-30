
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

        public static bool UsersIconDisplayesUsersName(string usersName)
        {
            string locator = "//*[@id='loyalty-modal-button']/span";
            Common.WaitForTheElementThatContainsTextValue(locator, usersName);

            return true;
        }

        public static void Logout()
        {
            string iconLocator = "//*[@id='loyalty-modal-button']/span";
            Common.Click(iconLocator);

            string logOutButton = "//*[@id='header__button']/span";
            Common.WaitForTheElementToBeVisible(logOutButton);
            Common.Click(logOutButton);
        }
    }
}
