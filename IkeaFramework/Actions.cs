using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaFramework
{
    public class Actions
    {

        public static void CtrlShiftClickOnElement(IWebElement element)
        {
            Actions actions = new Actions(Driver.GetDriver());
            actions.KeyDown(Keys.Control).KeyDown(Keys.Shift).Click(element).KeyUp(Keys.Control).KeyUp(Keys.Shift).Build().Perform();
        }
    }
}
