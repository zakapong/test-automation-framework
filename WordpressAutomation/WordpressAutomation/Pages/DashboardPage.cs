﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WordpressAutomation
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                // Refactor: Can we create a generalized IsAt for all pages?
                var h1s = Driver.Instance.FindElements(By.TagName("h1"));
                if (h1s.Count > 0)
                    return h1s[0].Text == "Dashboard";
                return false;
            }
        }
    }
}
