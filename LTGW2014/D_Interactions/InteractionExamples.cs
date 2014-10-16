using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGW2014.D_Interactions
{
    [TestClass]
    public class InteractionExamples
    {
        [TestMethod]
        public void D_SimpleInteractions()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("http://www.twitter.com");

            //Read the text of an element, in this case the first H1 tag.
            Console.WriteLine(Driver.FindElement(By.TagName("h1")).Text);
            //Enter a value in the username field using SendKeys.
            Driver.FindElement(By.Id("signin-email")).SendKeys("FriendlyTester");
            //Read the value that is in the username input field
            Console.WriteLine(Driver.FindElement(By.Id("signin-email")).GetAttribute("value"));
            //We can read any attribute
            //Read the placeholder attribute of the password field
            Console.WriteLine(Driver.FindElement(By.Id("signin-password")).GetAttribute("placeholder"));
            //Click on the first button, the sign in button in this instance
            Driver.FindElement(By.CssSelector("button.submit.primary-btn")).Click();
        }

        [TestMethod]
        public void D_DriverInteractions()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("http://www.twitter.com");
            //Click on the first button, the sign in button in this instance
            Driver.FindElement(By.CssSelector("button.submit.primary-btn")).Click();
            //Read the url of the page.
            Console.WriteLine(Driver.Url);
            //Read the page title / tab title
            Console.WriteLine(Driver.Title);
        }
    }
}
