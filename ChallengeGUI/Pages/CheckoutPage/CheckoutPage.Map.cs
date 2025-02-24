using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class CheckoutPage
    {
        protected By CheckoutTitle => By.XPath("//span[@class='title' and text()='Checkout: Your Information']");

        protected By FirstName => By.Id("first-name");
        protected By LastName => By.Id("last-name");
        protected By ZipCode => By.Id("postal-code");

        protected By ContinueButton => By.Id("continue");
        protected By FinishButton => By.Id("finish");

        protected By ProductsItemsPrices => By.XPath("//div[@class='inventory_item_price']");

        protected By TaxPrice => By.XPath("//div[@class='summary_tax_label']");
        protected By TotalPrice => By.XPath("//div[@class='summary_total_label']");

        protected By ErrorMessage => By.XPath("//div[@class='error-message-container error']");
        protected By ConfirmationMessage => By.XPath("//h2[@class='complete-header']");
    }
}
