using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Core
{
    public static class Abilities
    {
        public static void SetText(By locator, string text)
        {
            Driver.ShortWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            var element = Driver.Browser.FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        public static void Click(By locator)
        {
            Driver.ShortWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            Driver.Browser.FindElement(locator).Click();
        }
    }
}
