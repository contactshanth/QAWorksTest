
namespace ContactUs.Tests
{
using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ContactUs.Pages;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using ContactUs.Commons;

    [Binding]
    public class ContactUsDef
    {
        
        
        TestContext testcontext = new TestContext();
        Properties Homepage = new Properties();

        [Given(@"I am on the QAWorks (.*) and Click")]
        public void GivenIAmOnTheQAWorksAndClick()
        {

         
           IWebDriver driver = new FirefoxDriver();

           driver.Navigate().GoToUrl("site");
           IWebElement contact = driver.FindElement(By.LinkText("contact"));
           contact.Click();
         }

        
                                 

        [Then(@"Then I should be able to contact QAWorks with (.*) and (.*) the (.*) information")]
        public void ThenThenIShouldBeAbleToContactQAWorksWithAndTheInformation(string name, string email, string message)
        {
            
            Properties Homepage = new Properties();
            IWebDriver driver = new FirefoxDriver();
            
            IWebElement Name = driver.FindElement(By.Id("ctl00_MainContent_NameBox"));
            Name.SendKeys(name);

            IWebElement Email = driver.FindElement(By.Id("ctl00_MainContent_EmailBox"));
            Email.SendKeys(email);

            IWebElement Message = driver.FindElement(By.Id("ctl00_MainContent_MessageBox"));
            Message.SendKeys(message);

            IWebElement Send = driver.FindElement(By.Id("ctl00$MainContent$SendButton"));
            Send.Submit();
   
        }
    }

}
