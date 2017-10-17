using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Sample.pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public HomePage GoTo()
        {
            Driver.Navigate().GoToUrl("https://github.com/");
            Driver.Manage().Window.Maximize();

            return new HomePage(Driver);

        }


        public LoginPage clickSignIn()
        {
            Driver.FindElement(By.LinkText("Sign in")).Click();

            return new LoginPage(Driver);
        }

    }
    }
