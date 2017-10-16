using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.tests
{
    [TestClass]
    public class BaseTest
    {
        protected static  IWebDriver Driver { get; private set; }

        public BaseTest()
        {
       
            if(Driver == null)
            {
                Driver = new ChromeDriver();
            }
       



        }

    }
}
