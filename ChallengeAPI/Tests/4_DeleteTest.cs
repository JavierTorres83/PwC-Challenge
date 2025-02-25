using ChallengeAPI.Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAPI.Tests
{
    class DeleteTest : TestBase
    {
        [Description("Delete Booking")]
        [Category("TC_4"), Category("Delete"), Category("Scenario_01")]
        [Test]
        public void Delete_01()
        {
            Booking booking = new Booking("William", "Hammer");

            var response = Api.CreateBooking(booking);

            var bookID = Api.GetJsonValue(response, "bookingid");
            var token = Api.GetAuthToken(User.Valid.Username, User.Valid.Password);

            var request = new RestRequest($"/booking/{bookID}", Method.Delete);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", $"token={token}");
            var deleteResponse = Api.ExecuteRequest(request);

            Assert.That(deleteResponse.StatusCode == HttpStatusCode.Created);

            var getRequest = new RestRequest($"/booking/{bookID}", Method.Get);

            getRequest.AddHeader("Accept", "application/json");

            var getResponse = Api.ExecuteRequest(getRequest);

            Assert.That(getResponse.StatusCode == HttpStatusCode.NotFound);
        }

        [Description("Unauthorized Deletion")]
        [Category("TC_4"), Category("Delete"), Category("Scenario_02")]
        [Test]
        public void Delete_02()
        {
            Booking booking = new Booking("William", "Hammer");

            var response = Api.CreateBooking(booking);

            var bookID = Api.GetJsonValue(response, "bookingid");

            var request = new RestRequest($"/booking/{bookID}", Method.Delete);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", $"token=1425");
            var deleteResponse = Api.ExecuteRequest(request);

            Assert.That(deleteResponse.StatusCode == HttpStatusCode.Forbidden);
        }
    }
}
