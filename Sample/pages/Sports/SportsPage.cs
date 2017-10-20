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


        


        }

    }
