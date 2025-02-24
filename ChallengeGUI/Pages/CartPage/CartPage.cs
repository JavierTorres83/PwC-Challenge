using ChallengeGUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class CartPage
    {
        public CartPage RemoveFromCartItemByPos(string pos)
        {
            Abilities.Click(RemoveFromCartButtonByPos(pos));
            return this;
        }

        public void Checkout()
        {
            Abilities.Click(CheckoutButton);
        }
    }
}
