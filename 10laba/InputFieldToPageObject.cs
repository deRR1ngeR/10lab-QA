using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10laba
{
    internal class InputFieldToPageObject
    {


        IWebDriver _driver;
        readonly By inputField = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div/div/input");
        readonly By dataIcon = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[3]/div/div[1]/div");
        readonly By secondIcon = By.XPath("/html/body/div[5]/div/div/div[2]/div/div/div[2]/div/div/form/div[3]/div/div[1]/div");
        readonly By chooseDate = By.XPath("/html/body/div[5]/div/div/div[2]/div/div/div[2]/div/div/form/div[3]/div/div[3]/div/div/div[2]/div[2]/div/div/div/div[2]/div[2]/div[3]/div[4]/div[3]/div/div[1]");
        readonly By findTicket = By.XPath("/html/body/div[5]/div/div/div[2]/div/div/div[2]/div/div/form/div[5]/button");

        public InputFieldToPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        public void InputFieldData()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            _driver.FindElement(inputField).SendKeys("Москва");
          
        }

        public void DataIcon()
        {
            _driver.FindElement(dataIcon).Click();
            _driver.FindElement(secondIcon).Click();

        }

        public void TakeDate()
        {
            _driver.FindElement(chooseDate).Click();
        }
        public void FindTicket()
        {
            _driver.FindElement(findTicket).Click();
        }

    }
}
