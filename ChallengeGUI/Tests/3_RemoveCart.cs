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
    public class RemoveCart : TestBase
    {
        [Description("Remove Product from Cart")]
        [Category("TC_3"), Category("RemoveCart"), Category("Scenario_01")]
        [Test]
        public void RemoveCart_01()
        {
            LoginPage.Instance.LoginToSauceDemoWith(TestSettings.StandardUser);
            ProductPage.Instance.AssertPageLoadedCorrectly();

            ProductPage.Instance.AddToCartItemByPos("1").AssertCartNumber("1");
            ProductPage.Instance.AddToCartItemByPos("2").AssertCartNumber("2");

            ProductPage.Instance.GoToCart();

            CartPage.Instance.AssertPageLoadedCorrectly();

            CartPage.Instance.RemoveFromCartItemByPos("1");
            CartPage.Instance.AssertCartNumber("1");
        }
    }
}
