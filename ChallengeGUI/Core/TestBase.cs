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
        public ProductsPage productsPage;

        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();

            loginPage = new LoginPage();
            productsPage = new ProductsPage();
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
