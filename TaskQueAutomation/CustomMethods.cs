using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskQueAutomation
{
    class CustomMethods
    {
        public static void ExplicitWait(String Element, int TimeInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(Browser.wdriver, TimeSpan.FromSeconds(TimeInSeconds));
            wait.Until(d => d.FindElement(By.Id(Element)));
        }
    }
}
