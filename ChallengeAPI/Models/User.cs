using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAPI.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static User Valid => new User() { Username = "admin", Password = "password123" };
        public static User Invalid => new User() { Username = "Invalid", Password = "" };
    }

}
