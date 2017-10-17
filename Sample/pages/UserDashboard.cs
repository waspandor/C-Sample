using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.pages
{
    public class UserDashboard : BasePage
    {
        String pageTitle = "GitHub";

        public UserDashboard(IWebDriver driver) : base(driver)
        {

            String getPageTitle = Driver.Title;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Assert.AreEqual(getPageTitle, pageTitle);
        }

       

    }
}
