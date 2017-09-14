using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskQueAutomation
{
    class Program
    {
        /* BaseURL of web application */
        public static string BaseURL = "https://taskque.com/user/auth";

        /* Login credentials*/
        private static string Username = "";
        private static string Password = "";

        static void Main(string[] args)
        {
        }

        [SetUp] /*WebDriver Initilization method */
        public void Initilize()
        {
            Browser.wdriver = new ChromeDriver();
            Browser.wdriver.Navigate().GoToUrl(BaseURL);
            Browser.wdriver.Manage().Window.Maximize();
            LoginObjectModel loginApp = new LoginObjectModel();
            loginApp.Login(Username, Password);
            
        }

        [Test]
        public void CreateTask()
        {
            AddTaskObjectModel ad = new AddTaskObjectModel();
            ad.CreateTask();
        }


        
        [TearDown]
        public void CleanUp()
        {
            //Browser.wdriver.Close();
        }

        


    }
}
