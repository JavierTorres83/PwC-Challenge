using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Core
{
    public class Abilities
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

        public static decimal ConvertPriceToDecimal(string priceText, bool tax = false, bool total = false)
        {
            if(tax)
                return decimal.Parse(priceText.Replace("Tax: $", "").Trim(), CultureInfo.InvariantCulture);

            if(total)
                return decimal.Parse(priceText.Replace("Total: $", "").Trim(), CultureInfo.InvariantCulture);

            return decimal.Parse(priceText.Replace("$", "").Trim(), CultureInfo.InvariantCulture);
        }

        public static void SelectDropdownByText(By dropdownLocator, string text)
        {
            var dropdownElement = Driver.Browser.FindElement(dropdownLocator);
            var selectElement = new SelectElement(dropdownElement);
            selectElement.SelectByText(text);
        }
    }
}
