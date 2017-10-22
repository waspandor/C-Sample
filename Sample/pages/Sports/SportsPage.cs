using OpenQA.Selenium;

namespace Sample.pages
{
    public class SportsPage : BasePage
    {

        string pageTitle = "";

        public SportsPage(IWebDriver driver) : base(driver)
        {
        }

        public FootballPage goToFootballPage()
        {
            Driver.FindElement(By.LinkText("Football")).Click();
            return new FootballPage(Driver);
        }


        public Formula1Page goToFormula1Page()
        {
            Driver.FindElement(By.LinkText("Formula 1")).Click();
            return new Formula1Page(Driver);
        }


    }

    }
