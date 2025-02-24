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
    public class AddCart : TestBase
    {
        [Description("Add Single Product to Cart")]
        [Category("TC_2"), Category("AddCart"), Category("Scenario_01")]
        [Test]
        public void AddCart_01()
        {
            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();

            productsPage.AddToCartItemByPos("1").AssertCartNumber("1");
        }

        [Description("Add Multiple Product to Cart")]
        [Category("TC_2"), Category("AddCart"), Category("Scenario_02")]
        [Test]
        public void AddCart_02()
        {
            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();

            productsPage.AddToCartItemByPos("1").AssertCartNumber("1");
            productsPage.AddToCartItemByPos("2").AssertCartNumber("2");
            productsPage.AddToCartItemByPos("3").AssertCartNumber("3");
        }
    }
}
