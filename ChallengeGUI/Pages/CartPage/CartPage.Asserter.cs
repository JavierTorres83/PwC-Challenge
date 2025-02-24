using ChallengeGUI.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Pages
{
    public partial class CartPage
    {
        public void AssertPageLoadedCorrectly()
            => Asserts.AssertElementVisible(CartTitle, "Cart Title");

        public void AssertCartNumber(string expectedNumber)
            => Asserts.AssertElementText(CartNumber, expectedNumber);
    }
}
