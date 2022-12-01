using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10laba
{
    internal class MainMenuPageObject
    {
        private IWebDriver _driver;
        readonly By _checkTicketButton = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div/div[2]/div/div/button");
        public MainMenuPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public BuyTicketPageObject CheckTicket()
        {
            _driver.FindElement(_checkTicketButton).Click();
            return new BuyTicketPageObject(_driver);
        }
    }
}
