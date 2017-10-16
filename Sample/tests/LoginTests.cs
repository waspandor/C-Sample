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
        [TestMethod]
        public void TestOne()
        {

            LoginPage login = new LoginPage(Driver);
            login.GoTo().GoToSports();

        }


    }
}
