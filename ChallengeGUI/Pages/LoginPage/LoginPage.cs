using ChallengeGUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class LoginPage
    {
        public void LoginToSauceDemoWith(string user)
        {
            Driver.Browser.Navigate().GoToUrl(TestSettings.SauceDemoURL);

            Abilities.SetText(UserNameInput, user);
            Abilities.SetText(PasswordInput, TestSettings.Password);

            Abilities.Click(LoginButton);
        }
    }
}
