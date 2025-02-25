using System;
using System.Net;
using System.Xml.Linq;
using ChallengeAPI.Core;
using ChallengeAPI.Models;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;

namespace ChallengeAPI.Tests
{
    [TestFixture]
    public class AuthTest : TestBase
    {
        [Description("Valid Authentication")]
        [Category("TC_1"), Category("Auth"), Category("Scenario_01")]
        [Test]
        public void Auth_01()
        {
            var token = Api.GetAuthToken(User.Valid.Username, User.Valid.Password);
            Assert.That(token != null);
        }

        [Description("Invalid Authentication")]
        [Category("TC_1"), Category("Auth"), Category("Scenario_02")]
        [Test]
        public void Auth_02()
        {
            var token = Api.GetAuthToken(User.Invalid.Username, User.Invalid.Password);
            Assert.That(token == null);
        }
    }
}