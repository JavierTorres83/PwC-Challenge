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
    public class UpdateTest : TestBase
    {
        [Description("Update Booking")]
        [Category("TC_3"), Category("Update"), Category("Scenario_01")]
        [Test]
        public void Update_01()
        {
            Booking booking = new Booking("John", "Doe");

            var response = Api.CreateBooking(booking);

            var bookID = Api.GetJsonValue(response, "bookingid");
            var token = Api.GetAuthToken(User.Valid.Username, User.Valid.Password);

            var request = new RestRequest($"/booking/{bookID}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cookie", $"token={token}");

            var editedBody = new
            {
                firstname = "Edited",
                lastname = booking.LastName,
                totalprice = booking.TotalPrice,
                depositpaid = booking.DepositPaid,
                bookingdates = new
                {
                    checkin = booking.CheckIn,
                    checkout = booking.CheckOut
                },
                additionalneeds = booking.AdditionalNeeds
            };

            request.AddJsonBody(editedBody);

            var PUTResponse = Api.ExecuteRequest(request);

            var firstName = Api.GetJsonValue(PUTResponse, "firstname");


            Assert.That(PUTResponse.StatusCode == HttpStatusCode.OK);
            Assert.That(firstName == "Edited");
        }

        [Description("Unauthorize Update")]
        [Category("TC_3"), Category("Update"), Category("Scenario_02")]
        [Test]
        public void Update_02()
        {
            Booking booking = new Booking("John", "Doe");

            var response = Api.CreateBooking(booking);

            var bookID = Api.GetJsonValue(response, "bookingid");

            var request = new RestRequest($"/booking/{bookID}", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cookie", $"token=12342");

            var editedBody = new
            {
                firstname = "Edited",
                lastname = booking.LastName,
                totalprice = booking.TotalPrice,
                depositpaid = booking.DepositPaid,
                bookingdates = new
                {
                    checkin = booking.CheckIn,
                    checkout = booking.CheckOut
                },
                additionalneeds = booking.AdditionalNeeds
            };

            request.AddJsonBody(editedBody);

            var PUTResponse = Api.ExecuteRequest(request);

            Assert.That(PUTResponse.StatusCode == HttpStatusCode.Forbidden);
        }
    }
}
