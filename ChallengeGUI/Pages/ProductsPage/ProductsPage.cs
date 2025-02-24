using ChallengeGUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class ProductsPage
    {
        public void Logout()
        {
            Abilities.Click(MenuButton);
            Abilities.Click(LogoutButton);
        }
    }
}
