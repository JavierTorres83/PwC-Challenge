using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI.Core
{
    public abstract class TestBase
    {
        [SetUp]
        public void SetUp()
        {
            TestSettings.SetUpSettings();
            Driver.StartBrowser();
        }

        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                Driver.TakeScreenshot(TestContext.CurrentContext);

            Driver.StopBrowser();
        }
    }
}
