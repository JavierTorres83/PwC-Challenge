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
    public class BookingTest : TestBase
    {
        [Description("Create Booking")]
        [Category("TC_2"), Category("Booking"), Category("Scenario_01")]
        [Test]
        public void Booking_01()
        {
            Booking booking = new Booking("John", "Doe");

            var response = Api.CreateBooking(booking);
            var bookID = Api.GetJsonValue(response, "bookingid");

            Assert.That(response.StatusCode == HttpStatusCode.OK);
            Assert.That(bookID != null);
        }

        [Description("Retrieve Booking Details")]
        [Category("TC_2"), Category("Booking"), Category("Scenario_02")]
        [Test]
        public void Booking_02()
        {
            Booking booking = new Booking("John", "Doe");

            var createResponse = Api.CreateBooking(booking);
            var bookingID = Api.GetJsonValue(createResponse, "bookingid");

            var request = new RestRequest($"/booking/{bookingID}", Method.Get);

            request.AddHeader("Accept", "application/json");

            var getResponse = Api.ExecuteRequest(request);

            var firstName = Api.GetJsonValue(getResponse,"firstname");
            var lastName = Api.GetJsonValue(getResponse,"lastname");

            Assert.That(firstName == booking.FirstName);
            Assert.That(lastName == booking.LastName);
        }

        [Description("Invalid Booking Retrival")]
        [Category("TC_2"), Category("Booking"), Category("Scenario_03")]
        [Test]
        public void Booking_03()
        {
            var request = new RestRequest($"/booking/123213", Method.Get);

            request.AddHeader("Accept", "application/json");

            var getResponse = Api.ExecuteRequest(request);

            Assert.That(getResponse.StatusCode == HttpStatusCode.NotFound);
        }
    }
}
