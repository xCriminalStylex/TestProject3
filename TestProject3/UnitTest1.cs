using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TestProject3.PageObject;


namespace TestProject3
{
    public class UnitTest1: BaseTest
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = StartDriverOnPage("https://edhrec.com/");
            HomePage homePage = new HomePage(driver);
            homePage.clickCards().clickTopCards().clickPastWeek();
            
        }
        [Fact]
        public void Test2()
        {
            IWebDriver driver = StartDriverOnPage("https://edhrec.com/");
            HomePage homePage = new HomePage(driver);
            
            homePage.clickCards().SaltiestCards();
        }
    }
}
