using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGW2014.C_Locators
{
    [TestClass]
    //Locators are one of the biggest problems with UI Automation
    //A minimal locator is a must
    //Work with your developers to get short locators
    public class LocatorExamples
    {
        [TestMethod]
        public void C_AllLocators()
        {
                //Start a Firefox Instance
                var Driver = new FirefoxDriver();
                //Navigate to a Website.
                Driver.Navigate().GoToUrl("http://www.twitter.com");

            var ElementByClassName = Driver.FindElement(By.ClassName("text-input"));
            var ElementByCssSelector = Driver.FindElement(By.CssSelector("input.text-input.email-input"));
            var ElementByID = Driver.FindElement(By.Id("signin-email"));
            //var ElementBy = Driver.FindElement(By.LinkText(""));
            var ElementByName = Driver.FindElement(By.Name("session[username_or_email]"));
            var ElementByTagName = Driver.FindElement(By.TagName("input"));
            var ElementByXPath = Driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div[2]/form/div[1]/input"));
            
            //But they can be different            
            var ElementByXPath1 = Driver.FindElement(By.XPath("//*[@id=\"signin-email\"]"));
            var ElementByCssSelector1 = Driver.FindElement(By.CssSelector("#signin-email"));
        }

        [TestMethod]
        public void C_FindElements()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("http://www.twitter.com");

            var inputs = Driver.FindElementsByTagName("input").ToList();
            //13/10/2014 it was number 9
            var ElementByTagFindAll = inputs[9];
        }
    }
}
