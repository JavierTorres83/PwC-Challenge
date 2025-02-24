using ChallengeGUI.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class CheckoutPage
    {
        public void AssertPageLoadedCorrectly()
            => Asserts.AssertElementVisible(CheckoutTitle, "Checkout Title");

        public void AssertTotalPrice()
        {
            IList<IWebElement> priceElements = Driver.Browser.FindElements(ProductsItemsPrices);
            List<decimal> prices = priceElements.Select(e => Abilities.ConvertPriceToDecimal(e.Text)).ToList();
            decimal sumOfItems = prices.Sum();

            var taxElement = Driver.Browser.FindElement(TaxPrice);
            decimal taxDisplayed = Abilities.ConvertPriceToDecimal(taxElement.Text, true);

            var totalElement = Driver.Browser.FindElement(TotalPrice);
            decimal totalDisplayed = Abilities.ConvertPriceToDecimal(totalElement.Text, false, true);

            Assert.That(sumOfItems + taxDisplayed == totalDisplayed);
        }

        public void AssertErrorMessage()
            => Asserts.AssertElementVisible(ErrorMessage, "Error Message");

        public void AssertConfirmationMessage()
            => Asserts.AssertElementVisible(ConfirmationMessage, "Confirmation Message");
    }
}
