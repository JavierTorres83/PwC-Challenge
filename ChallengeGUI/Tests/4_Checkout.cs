using ChallengeGUI.Core;
using ChallengeGUI.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Tests
{
    [TestFixture]
    public class Checkout : TestBase
    {
        [Description("Successful checkout")]
        [Category("TC_4"), Category("Checkout"), Category("Scenario_01")]
        [Test]
        public void Checkout_01()
        {
            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();

            productsPage.AddToCartItemByPos("1").AssertCartNumber("1");
            productsPage.AddToCartItemByPos("2").AssertCartNumber("2");

            productsPage.GoToCart();
            cartPage.AssertPageLoadedCorrectly();

            cartPage.Checkout();
            checkoutPage.AssertPageLoadedCorrectly();

            checkoutPage.PopulateFirstName("John");
            checkoutPage.PopulateLastName("Wick");
            checkoutPage.PopulateZipCode("2301");

            checkoutPage.Continue();

            checkoutPage.AssertTotalPrice();

            checkoutPage.Finish().AssertConfirmationMessage();
        }

        [Description("Checkout with Missing Details.")]
        [Category("TC_4"), Category("Checkout"), Category("Scenario_02")]
        [Test]
        public void Checkout_02()
        {
            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();

            productsPage.AddToCartItemByPos("1").AssertCartNumber("1");
            productsPage.AddToCartItemByPos("2").AssertCartNumber("2");

            productsPage.GoToCart();
            cartPage.AssertPageLoadedCorrectly();

            cartPage.Checkout();
            checkoutPage.AssertPageLoadedCorrectly();

            checkoutPage.PopulateFirstName("John");
            checkoutPage.PopulateLastName("Wick");

            checkoutPage.Continue();

            checkoutPage.AssertErrorMessage();
        }
    }
}
