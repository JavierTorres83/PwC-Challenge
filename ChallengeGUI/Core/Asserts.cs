using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Core
{
    public static class Asserts
    {
        public static void AssertElementVisible(By locator, string locatorName)
        {
            Driver.ShortWait.Until(ExpectedConditions.ElementIsVisible(locator));
            IWebElement element = Driver.Browser.FindElement(locator);
            Assert.That(element.Displayed, $"The following element isnt visible: {locatorName}");
        }

        public static void AssertElementText(By locator, string text)
        {
            Driver.ShortWait.Until(ExpectedConditions.ElementIsVisible(locator));
            IWebElement element = Driver.Browser.FindElement(locator);
            Assert.That(element.Text.Equals(text), $"Expected text: {text}, but actual text: {element.Text}");
        }
    }

}
