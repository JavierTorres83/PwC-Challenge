using ChallengeGUI.Core;
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
            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();

            productsPage.AddToCartItemByPos("1").AssertCartNumber("1");
            productsPage.AddToCartItemByPos("2").AssertCartNumber("2");

            productsPage.GoToCart();

            cartPage.AssertPageLoadedCorrectly();

            cartPage.RemoveFromCartItemByPos("1");
            cartPage.AssertCartNumber("1");
        }
    }
}
