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
            LoginPage.Instance.LoginToSauceDemoWith(TestSettings.StandardUser);
            ProductPage.Instance.AssertPageLoadedCorrectly();

            ProductPage.Instance.AddToCartItemByPos("1").AssertCartNumber("1");
            ProductPage.Instance.AddToCartItemByPos("2").AssertCartNumber("2");

            ProductPage.Instance.GoToCart();
            CartPage.Instance.AssertPageLoadedCorrectly();

            CartPage.Instance.Checkout();
            CheckoutPage.Instance.AssertPageLoadedCorrectly();

            CheckoutPage.Instance.PopulateFirstName("John");
            CheckoutPage.Instance.PopulateLastName("Wick");
            CheckoutPage.Instance.PopulateZipCode("2301");

            CheckoutPage.Instance.Continue();

            CheckoutPage.Instance.AssertTotalPrice();

            CheckoutPage.Instance.Finish().AssertConfirmationMessage();
        }

        [Description("Checkout with Missing Details.")]
        [Category("TC_4"), Category("Checkout"), Category("Scenario_02")]
        [Test]
        public void Checkout_02()
        {
            LoginPage.Instance.LoginToSauceDemoWith(TestSettings.StandardUser);
            ProductPage.Instance.AssertPageLoadedCorrectly();

            ProductPage.Instance.AddToCartItemByPos("1").AssertCartNumber("1");
            ProductPage.Instance.AddToCartItemByPos("2").AssertCartNumber("2");

            ProductPage.Instance.GoToCart();
            CartPage.Instance.AssertPageLoadedCorrectly();

            CartPage.Instance.Checkout();
            CheckoutPage.Instance.AssertPageLoadedCorrectly();

            CheckoutPage.Instance.PopulateFirstName("John");
            CheckoutPage.Instance.PopulateLastName("Wick");

            CheckoutPage.Instance.Continue();

            CheckoutPage.Instance.AssertErrorMessage();
        }
    }
}
