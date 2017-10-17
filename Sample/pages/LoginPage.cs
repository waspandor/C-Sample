using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.pages
{
    public class LoginPage : BasePage
    {

        String username;
        String password;
        String pageTitle = "Sign in to GitHub · GitHub";

        public LoginPage(IWebDriver driver) : base(driver)
        {

            String getPageTitle = Driver.Title;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Assert.AreEqual(getPageTitle, pageTitle);
        }

        public LoginPage enterUsername(String username)
        {
            Driver.FindElement(By.Name("login")).SendKeys(username);
            return new LoginPage(Driver);
        }

        public LoginPage enterPassword(String password)
        {

            Driver.FindElement(By.Name("password")).SendKeys(password);
            return new LoginPage(Driver);
        }


        public UserDashboard LoginWithDetails()
        {
   
            Driver.FindElement(By.Name("commit")).Submit();
            return new UserDashboard(Driver);
        }

    }
}