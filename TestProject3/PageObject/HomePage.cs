using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject3.PageObject
{
     public class HomePage
    {
        private IWebDriver _driver;
        private By _navBarCards = By.Id("navbar-cards");
        private By _topCards = By.CssSelector("#navbar > div.mr-auto.navbar-nav > div.nav-item.show.dropdown > div > a:nth-child(1) > span");
        private By _saltiestCards = By.CssSelector("#navbar > div.mr-auto.navbar-nav > div.nav-item.show.dropdown > div > a:nth-child(2) > span");
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public HomePage clickCards()
        {
            _driver.FindElement(_navBarCards).Click();
            return this;
        }
        public TopCards clickTopCards()
        {
            _driver.FindElement(_topCards).Click();
            return new TopCards(_driver);
        }
        public SaltiestCards SaltiestCards()
        {
            _driver.FindElement(_saltiestCards).Click();
            return new SaltiestCards(_driver);
        }
    }
}
