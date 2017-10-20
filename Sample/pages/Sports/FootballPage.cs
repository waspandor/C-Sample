using OpenQA.Selenium;

namespace Sample.pages
{
    public class FootballPage : BasePage


    {
  
        public FootballPage(IWebDriver driver) : base(driver)
        {
        }

        public ScoresFixturesPage goToScoresFixturesPage()
        {
            Driver.FindElement(By.LinkText("Scores & Fixtures")).Click();


            return new ScoresFixturesPage(Driver);
        }

    }
}