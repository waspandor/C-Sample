using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Sample.pages;
using Sample.tests;

namespace Sample
{
    [TestClass]
    public class LoginTests : BaseTest
    {

        HomePage homePage;

        [TestMethod]
        public void TestOne()
        {

            homePage = new HomePage(Driver);
            homePage.
                goToHomePage().
                useTopNav().
                search("pakistan");
      

        }


    }
}
