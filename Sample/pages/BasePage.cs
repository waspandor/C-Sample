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


        public SportsPage goToSportsPage()
        {
            Driver.FindElement(By.LinkText("Sport")).Click();
            return new SportsPage(Driver);
        }

        public NewsPage goToNewsPage()
        {
            Driver.FindElement(By.LinkText("News")).Click();
            return new NewsPage(Driver);
        }

        public WeatherPage goToWeatherPage()
        {
            Driver.FindElement(By.LinkText("Weather")).Click();
            return new WeatherPage(Driver);
        }

        public SearchResultsPage search(String searchTerm)


        {
            Driver.FindElement(By.Id("orb-search-q")).SendKeys(searchTerm);
            //   Driver.FindElement(By.Id("se-searchbox-input-field")).SendKeys(searchTerm);
            Driver.FindElement(By.ClassName("se-searchbox__submit")).Click();

            return new SearchResultsPage(Driver);
        }

    }
}
