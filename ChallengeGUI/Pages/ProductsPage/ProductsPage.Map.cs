using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class ProductsPage
    {
        protected By ProductsTitle => By.ClassName("title");

        protected By MenuButton => By.Id("react-burger-menu-btn");
        protected By LogoutButton => By.Id("logout_sidebar_link");
    }
}
