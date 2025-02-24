using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class CartPage
    {
        protected By CartTitle => By.XPath("//span[@class='title' and text()='Your Cart']");
        protected By CartNumber => By.ClassName("shopping_cart_badge");

        protected By CheckoutButton => By.Id("checkout");

        // -- Cart Items By Position
        protected By CartItemByPos(string pos) => By.XPath($"//div[@class='cart_item_label'][{pos}]");
        protected By RemoveFromCartButtonByPos(string pos) => By.XPath($"//div[@class='cart_item_label'][{pos}]//button[text()='Remove']");
    }
}
