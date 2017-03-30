using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskQueAutomation
{
    class AddTaskObjectModel
    {
        public AddTaskObjectModel()
        {
            PageFactory.InitElements(Browser.wdriver, this);
        }


        [FindsBy(How = How.XPath, Using = "html/body/div[1]/tq-app/div[2]/div/task-listing/div[2]/div[2]/div/div[2]/div/div/div/button")]
        public IWebElement btn_NewTask { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[4]/md-dialog/form/md-dialog-content/div[1]/div[1]/md-input-container/div[1]/textarea")]
        public IWebElement txt_TaskName { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[4]/md-dialog/form/md-dialog-content/div[1]/div[3]/div[1]/md-menu/button")]                                 
        public IWebElement dropd_Assigned { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[5]/md-menu-content/div[2]/div[1]/div/md-radio-group/md-menu-item/md-radio-button")]
        public IWebElement dropd_AssignedUser { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[4]/md-dialog/form/md-dialog-content/div[1]/div[3]/div[2]/md-menu/button")]
        public IWebElement dropd_DateDue { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[4]/md-dialog/form/md-dialog-content/div[1]/div[3]/div[3]/md-menu/button")]
        public IWebElement dropd_Project { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[4]/md-dialog/form/md-dialog-actions/button")]
        public IWebElement btn_AddTask { get; set; }

        public void CreateTask()
        {
            string TaskName = "Testing Task";

            WebDriverWait wait = new WebDriverWait(Browser.wdriver, TimeSpan.FromSeconds(150));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("html/body/div[1]/tq-app/div[2]/div/task-listing/div[2]/div[2]/div/div[2]/div/div/div/button")));

            btn_NewTask.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("html/body/div[4]/md-dialog/form/md-dialog-content/div[1]/div[1]/md-input-container/div[1]/textarea")));
            txt_TaskName.SendKeys(TaskName);            
            btn_AddTask.Click();
        }
    }
}
