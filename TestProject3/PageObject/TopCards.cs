using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject3.PageObject
{
    public class TopCards
    {
        private IWebDriver _driver;
        public TopCards(IWebDriver driver)
        {
            _driver = driver;
        }
        private By _pastWeekButton = By.LinkText("Past Week");
        public TopCards clickPastWeek()
        {
            _driver.FindElement(_pastWeekButton).Click();
            return this;
        }
    }
}
