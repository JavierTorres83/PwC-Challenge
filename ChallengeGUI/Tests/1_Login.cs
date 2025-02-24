using ChallengeGUI.Core;
using NUnit.Framework;

namespace ChallengeGUI.Tests
{
    [TestFixture]
    public class Login : TestBase
    {
        [Description("Login with valid User")]
        [Category("TC_1"), Category("Login"), Category("Scenario_01")]
        [Test]
        public void Login_01()
        {
            loginPage.LoginToSauceDemoWith(TestSettings.StandardUser);
            productsPage.AssertPageLoadedCorrectly();   
        }

        [Description("Login with invalid User")]
        [Category("TC_1"), Category("Login"), Category("Scenario_02")]
        [Test]
        public void Login_02()
        {
            loginPage.LoginToSauceDemoWith("Invalid User");
            loginPage.AssertLoginErrorMessage();
        }
    }
}
