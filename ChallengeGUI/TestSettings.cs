using ChallengeGUI.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI
{
    public static class TestSettings
    {
        public static Driver.BrowserType Browser { get; set; }
        public static double LongWait { get; set; }
        public static double ShortWait { get; set; }
        public static string SauceDemoURL { get; set; }
        public static string StandardUser { get; set; }
        public static string ErrorUser { get; set; }
        public static string Password { get; set; }

        public static void SetUpSettings()
        {
            Browser = (Driver.BrowserType)Enum.Parse(typeof(Driver.BrowserType), ConfigurationManager.AppSettings["Browser"], true);

            LongWait = double.Parse(ConfigurationManager.AppSettings["LongWait"]);
            ShortWait = double.Parse(ConfigurationManager.AppSettings["ShortWait"]);

            SauceDemoURL = ConfigurationManager.AppSettings["SauceDemoURL"];

            StandardUser = ConfigurationManager.AppSettings["StandardUser"];
            ErrorUser = ConfigurationManager.AppSettings["ErrorUser"];

            Password = ConfigurationManager.AppSettings["Password"];
        }   
    }
}
