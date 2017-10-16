using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Sample.pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public LoginPage GoTo()
        {
            Driver.Navigate().GoToUrl("http://www.bbc.co.uk");

            return new LoginPage(Driver);

        }


        public LoginPage GoToSports()
        {
            Driver.FindElement(By.LinkText("Sport")).Click();

            return new LoginPage(Driver);
        }

    }
    }
