using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ContactUs.Commons;
using OpenQA.Selenium;


namespace ContactUs.Pages
{
    public class Properties 
    {


        public By Name = By.Id("ctl00_MainContent_NameBox");

        public By Email = By.Id("ctl00_MainContent_EmailBox");

        public By Message = By.Id("ctl00_MainContent_MessageBox");
     }
}