using ChallengeAPI.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAPI.Core
{
    public class ApiClient
    {
        private readonly RestClient _client;

        public ApiClient(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public RestResponse ExecuteRequest(RestRequest request)
        {
            return _client.Execute(request);
        }

        public string GetAuthToken(string username, string password)
        {
            var request = new RestRequest("/auth", Method.Post);
            request.AddJsonBody(new { username, password });

            var response = ExecuteRequest(request);
            var token = GetJsonValue(response, "token");

            return token;
        }

        public RestResponse CreateBooking(Booking booking)
        {
            var request = new RestRequest("/booking", Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            var body = new
            {
                firstname = booking.FirstName,
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

            request.AddJsonBody(body);

            return ExecuteRequest(request);
        }

        public string GetValue(RestResponse response, string value)
        {
            var jsonResponse = JObject.Parse(response.Content);
            var _value = jsonResponse[value]?.ToString();
            return _value.ToString();
        }

        public string GetJsonValue(RestResponse response, string value)
        {
            var jsonResponse = JObject.Parse(response.Content);
            var _value = jsonResponse[value]?.ToString();

            return _value;
        }

        public string Get2DJsonValue(RestResponse response, string value, string value2)
        {
            var jsonResponse = JObject.Parse(response.Content);
            var _value = jsonResponse[value][value2]?.ToString();

            return _value;
        }
    }
}
