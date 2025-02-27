using ChallengeGUI.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Core
{
    [TestFixture]
    public abstract class TestBase
    {
        [SetUp]
        public void SetUp() => Driver.StartBrowser();

        [TearDown]
        public void TearDown() => Driver.StopBrowser();
    }
}
