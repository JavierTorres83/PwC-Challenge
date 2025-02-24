using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class LoginPage
    {
        protected By UserNameInput => By.Id("user-name");
        protected By PasswordInput => By.Id("password");
        protected By LoginButton => By.Id("login-button");
        protected By LoginErrorMessage => By.XPath("//div[@class='error-message-container error']//h3");
    }
}
