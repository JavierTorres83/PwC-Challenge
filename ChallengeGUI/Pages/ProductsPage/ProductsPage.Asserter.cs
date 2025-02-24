using ChallengeGUI.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class ProductPage
    {
        public void AssertPageLoadedCorrectly()
            => Asserts.AssertElementVisible(ProductsTitle, "Product Title");

        public void AssertCartNumber(string expectedNumber)
            => Asserts.AssertElementText(CartNumber, expectedNumber);

        public void AssertSortType(string sortType)
        {
            var priceElements = Driver.Browser.FindElements(ProductsPrices);
            List<decimal> prices = priceElements.Select(e => Abilities.ConvertPriceToDecimal(e.Text)).ToList();

            switch (sortType.ToLower())
            {
                case "price (low to high)":
                    Assert.That(prices, Is.Ordered.Ascending);
                    break;
                case "price (high to low)":
                    Assert.That(prices, Is.Ordered.Descending);
                    break;
                default:
                    throw new Exception("Invalid Sort Type");
            }
        }
    }
}
