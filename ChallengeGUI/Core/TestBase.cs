using ChallengeGUI.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Core
{
    [TestFixture]
    public abstract class TestBase
    {
        public LoginPage loginPage;
        public ProductPage productsPage;
        public CartPage cartPage;
        public CheckoutPage checkoutPage;

        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();

            loginPage = new LoginPage();
            productsPage = new ProductPage();
            cartPage = new CartPage();
            checkoutPage = new CheckoutPage();
        }

        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                Driver.TakeScreenshot(TestContext.CurrentContext);

            Driver.StopBrowser();
        }
    }
}
