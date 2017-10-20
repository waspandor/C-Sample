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

        public HomePage goToHomePage()
        {
            Driver.Navigate().GoToUrl(baseUrl);
            return new HomePage(Driver);
            

        }


    }
    }
