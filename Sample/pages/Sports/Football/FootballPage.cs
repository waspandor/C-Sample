using OpenQA.Selenium;

namespace Sample.pages
{
    public class FootballPage : SportsPage


    {
  
        public FootballPage(IWebDriver driver) : base(driver)
        {
        }

        public ScoresFixturesPage goToScoresFixturesPage()
        {
            Driver.FindElement(By.LinkText("Scores & Fixtures")).Click();
            return new ScoresFixturesPage(Driver);
        }

        public TablesPage goToTablesPage()
        {
            Driver.FindElement(By.LinkText("Tables")).Click();
            return new TablesPage(Driver);
        }

    }
}