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
    public class PartialUpdateTest : TestBase
    {
        [Description("Partial Update Booking")]
        [Category("TC_5"), Category("PartialUpdate"), Category("Scenario_01")]
        [Test]
        public void PartialUpdate_01()
        {
            Booking booking = new Booking("John", "Doe");

            var response = Api.CreateBooking(booking);

            var bookID = Api.GetJsonValue(response, "bookingid");
            var token = Api.GetAuthToken(User.Valid.Username, User.Valid.Password);

            var request = new RestRequest($"/booking/{bookID}", Method.Patch);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cookie", $"token={token}");

            var editedBody = new
            {
                firstname = "Edited"
            };

            request.AddJsonBody(editedBody);

            var PatchResponse = Api.ExecuteRequest(request);

            var firstName = Api.GetJsonValue(PatchResponse, "firstname");


            Assert.That(PatchResponse.StatusCode == HttpStatusCode.OK);
            Assert.That(firstName == "Edited");

        }
    }
}
