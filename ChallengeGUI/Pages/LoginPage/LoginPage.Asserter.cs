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
        public void AssertLoginErrorMessage()
            => Asserts.AssertElementText(LoginErrorMessage, "Epic sadface: Username and password do not match any user in this service");

        public void AssertPageLoadedCorrectly()
            => Asserts.AssertElementVisible(LoginButton, "Login Button");
    }
}
