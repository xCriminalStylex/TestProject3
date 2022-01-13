using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject3.PageObject
{
    public class SaltiestCards
    {
        private IWebDriver _driver;
        public SaltiestCards(IWebDriver driver)
        {
            _driver = driver;
        }
        private By _saltiestCards = By.CssSelector("#navbar > div.mr-auto.navbar-nav > div.nav-item.show.dropdown > div > a:nth-child(2) > span");
        public SaltiestCards clickSaltiestCards()
        {
            _driver.FindElement(_saltiestCards).Click();
            return this;
        }
    }
}
