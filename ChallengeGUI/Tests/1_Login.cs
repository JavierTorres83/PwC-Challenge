using ChallengeGUI.Core;
using ChallengeGUI.Pages;
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
            // LoginPAge loginPage = new LoginPage(); other alternative but singleton is cleaner. for endurance test, this may be better.
            LoginPage.Instance.LoginToSauceDemoWith(TestSettings.StandardUser);
            ProductPage.Instance.AssertPageLoadedCorrectly();   
        }

        [Description("Login with invalid User")]
        [Category("TC_1"), Category("Login"), Category("Scenario_02")]
        [Test]
        public void Login_02()
        {
            LoginPage.Instance.LoginToSauceDemoWith("Invalid User");
            LoginPage.Instance.AssertLoginErrorMessage();
        }
    }
}
