using ChallengeGUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class CheckoutPage
    {
        public void PopulateFirstName(string firstName)
        {
            Abilities.SetText(FirstName, firstName);
        }

        public void PopulateLastName(string lastName)
        {
            Abilities.SetText(LastName, lastName);
        }

        public void PopulateZipCode(string zipCode)
        {
            Abilities.SetText(ZipCode, zipCode);
        }

        public void Continue()
        {
            Abilities.Click(ContinueButton);
        }

        public CheckoutPage Finish()
        {
            Abilities.Click(FinishButton);
            return this;
        }
    }
}
