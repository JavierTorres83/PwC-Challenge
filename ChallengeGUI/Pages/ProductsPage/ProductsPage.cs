using ChallengeGUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class ProductPage
    {
        public void Logout()
        {
            Abilities.Click(MenuButton);
            Abilities.Click(LogoutButton);
        }

        public ProductPage AddToCartItemByPos(string pos)
        {
            Abilities.Click(AddToCartButtonByPos(pos));
            return this;
        }

        public ProductPage RemoveFromCartItemByPos(string pos)
        {
            Abilities.Click(RemoveFromCartButtonByPos(pos));
            return this;
        }

        public void GoToCart()
        {
            Abilities.Click(CartButton);
        }

        public ProductPage SortBy(string sortType)
        {
            Abilities.SelectDropdownByText(SortByDropdown, sortType);
            return this;
        }

    }
}
