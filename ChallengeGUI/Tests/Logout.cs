using ChallengeGUI.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Tests
{
    public class Logout : TestBase
    {
        [Description("Logout")]
        [Category("TC_6"), Category("Logout"), Category("Scenario_01")]
        [Test]
        public void Logout_01()
        {
            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();

            productsPage.Logout();
            loginPage.AssertPageLoadedCorrectly();
        }
    }
}
