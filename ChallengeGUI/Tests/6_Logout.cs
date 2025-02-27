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
    public class Logout : TestBase
    {
        [Description("Logout")]
        [Category("TC_6"), Category("Logout"), Category("Scenario_01")]
        [Test]
        public void Logout_01()
        {
            LoginPage.Instance.LoginToSauceDemoWith(TestSettings.StandardUser);
            ProductPage.Instance.AssertPageLoadedCorrectly();

            ProductPage.Instance.Logout();
            LoginPage.Instance.AssertPageLoadedCorrectly();
        }
    }
}
