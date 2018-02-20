using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.ObjectModel;
using System.Threading;


namespace WordpressAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; internal set; }
        public static string BaseAddress
        {
            get { return "http://localhost/wordpress/"; }
        }

        public static void Initialize()
        {

            Instance = new FirefoxDriver();
            TurnOnWait();
        }

        public static void Close()
        {
           // Instance.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        internal static void NoWait(Action action)
        {
            TurnOffwait();
            action();
            TurnOnWait();
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
        }

        private static void TurnOffwait()
        {
            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(0));
        }
    }
}