using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class ProductPage
    {
        protected By ProductsTitle => By.ClassName("title");

        protected By MenuButton => By.Id("react-burger-menu-btn");
        protected By LogoutButton => By.Id("logout_sidebar_link");

        protected By CartButton => By.Id("shopping_cart_container");
        protected By CartNumber => By.ClassName("shopping_cart_badge");

        protected By SortByDropdown => By.XPath("//select[@class='product_sort_container']");

        protected By ProductsPrices => By.XPath("//div[@class='inventory_item_price']");

        // -- Cart Items By Position
        protected By ProductItemByPos(string pos) => By.XPath($"//div[@class='inventory_item'][{pos}]");
        protected By AddToCartButtonByPos(string pos) => By.XPath($"//div[@class='inventory_item'][{pos}]//button[text()='Add to cart']");
        protected By RemoveFromCartButtonByPos(string pos) => By.XPath($"//div[@class='inventory_item'][{pos}]//button[text()='Remove']");
    }
}
