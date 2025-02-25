using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalPrice { get; set; }
        public bool DepositPaid { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string AdditionalNeeds { get; set; }

        public Booking(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            TotalPrice = 0;
            DepositPaid = false;
            CheckIn = DateTime.Now.ToString("yyyy-MM-dd");
            CheckOut = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            AdditionalNeeds = "None";
        }
    }
}
