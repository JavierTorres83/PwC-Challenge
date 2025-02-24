using ChallengeGUI.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class ProductsPage
    {
        public void AssertPageLoadedCorrectly()
            => Asserts.AssertElementVisible(ProductsTitle, "Product Title");
    }
}
