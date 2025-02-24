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
    public class Sort : TestBase
    {
        [Description("Sort Products by Price (Low-High).")]
        [Category("TC_5"), Category("Sort"), Category("Scenario_01")]
        [Test]
        public void Sort_01()
        {
            var sortType = "Price (low to high)";

            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();

            productsPage.SortBy(sortType).AssertSortType(sortType);
        }
    }
}
