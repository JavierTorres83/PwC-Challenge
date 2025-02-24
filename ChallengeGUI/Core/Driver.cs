using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;using System.IO;

namespace ChallengeGUI.Core
{
    public static class Driver
    {
        static IWebDriver _browser;
        static WebDriverWait _longWait;
        static WebDriverWait _shortWait;

        public enum BrowserType
        {
            Chrome,
            Firefox,
            Edge,
        }

        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method StartBrowser.");
                return _browser;
            }
            private set
            {
                _browser = value;
            }
        }

        public static WebDriverWait LongWait
        {
            get
            {
                return _longWait;
            }
            private set
            {
                _longWait = value;
            }
        }

        public static WebDriverWait ShortWait
        {
            get
            {
                return _shortWait;
            }
            private set
            {
                _shortWait = value;
            }
        }

        public static void StartBrowser(){
            switch (TestSettings.Browser)
            {
                case BrowserType.Chrome:
                    InitializeChromeDriver();
                    break;
                case BrowserType.Firefox:
                    InitializeFireFoxDriver();
                    break;
                case BrowserType.Edge:
                    InitializeEdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Invalid Browser Type");
            }

            LongWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(TestSettings.LongWait));
            ShortWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(TestSettings.ShortWait));
        }

        private static void InitializeChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();

            if (TestSettings.Headless)
                options.AddArgument("--headless");

            options.SetLoggingPreference(LogType.Browser, LogLevel.Warning);

            Browser = new ChromeDriver(options);
        }

        private static void InitializeFireFoxDriver()
        {
            Browser = new OpenQA.Selenium.Firefox.FirefoxDriver();
        }

        private static void InitializeEdgeDriver()
        {
            Browser = new OpenQA.Selenium.Edge.EdgeDriver();
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser.Dispose();
            Browser = null;
        }

        public static string TakeScreenshot(TestContext context)
        {
            try
            {
                string screenshotDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
                string screenshotFileName = $"{context.Test.MethodName}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string screenshotPath = $"{screenshotDirectory}\\{screenshotFileName}";

                if (!Directory.Exists(screenshotDirectory))
                    Directory.CreateDirectory(screenshotDirectory);

                Screenshot screenshot = ((ITakesScreenshot)Browser).GetScreenshot();
                screenshot.SaveAsFile(screenshotPath);
                return screenshotPath;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while taking screenshot", e);
                return null;
            }
        }
    }
}
