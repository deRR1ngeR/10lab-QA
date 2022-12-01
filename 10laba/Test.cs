using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10laba
{
    internal class Tests
    {

        [Test]
        public void ViewScoreboardOfMinskStation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.aviasales.by/search/MSQ0612MOW1?request_source=best_prices";
            driver.Manage().Window.Maximize();
            MainMenuPageObject mainpage = new MainMenuPageObject(driver);


            mainpage.CheckTicket().BuyTicket();


        }

        [Test]
        public void FieldDataAndFindTicket()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.aviasales.by";
            driver.Manage().Window.Maximize();
            InputFieldToPageObject InputFieldTest = new InputFieldToPageObject(driver);
            InputFieldTest.InputFieldData();
            InputFieldTest.DataIcon();
            InputFieldTest.TakeDate();
            InputFieldTest.FindTicket();

        }

    }
}
