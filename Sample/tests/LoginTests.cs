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

        String username = "waspandor";
        String password = "treble99";

        [TestMethod]
        public void TestOne()
        {

            HomePage login = new HomePage(Driver);
            login.
                GoTo().
                clickSignIn().
                enterUsername(username).
                enterPassword(password).
                LoginWithDetails();

        }


    }
}
