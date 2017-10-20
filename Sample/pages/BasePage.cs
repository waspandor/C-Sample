using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.pages
{
   public class BasePage
    {

        public String baseUrl = "https://bbc.com/";

        public BasePage (IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Window.Maximize();

        }

        public IWebDriver Driver { get; set; }


        public TopNavBar useTopNav()
        {
            return new TopNavBar(Driver);
        }

    }
}
