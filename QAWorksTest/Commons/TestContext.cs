using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ContactUs.Commons
{
    public class TestContext
    {
        private IWebDriver webDriver;

        public IWebDriver WebDriver
        {
            get
            {
                if (webDriver == null)
                {
                    this.SetupWebdriver();
                }
                return this.webDriver;
            }
        }

        private void SetupWebdriver()
        {
            webDriver = new FirefoxDriver();
        }

        public void BrowseTopage(String link)
        {
            WebDriver.Navigate().GoToUrl(link);
        }

        

    }

    
}