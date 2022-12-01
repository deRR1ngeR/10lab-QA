using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10laba
{
    internal class BuyTicketPageObject
    {


        IWebDriver _driver;
        readonly By buyTicket = By.XPath("/html/body/div[23]/div/div/div/div/div[2]/div/div/div[1]/div[4]/div/a");
        public BuyTicketPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void BuyTicket()
        {
            _driver.FindElement(buyTicket).Click();
            
        }

        
    }
}
