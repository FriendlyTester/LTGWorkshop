using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGW2014.B_Navigation
{
    [TestClass]
    public class NavigationExamples
    {
        [TestMethod]
        public void Navigate()
        {
            //Create a driver
            var Driver = new FirefoxDriver();
            //We need to use to the Navigate method.
            Driver.Navigate().GoToUrl("http://thefriendlytester.co.uk");
            Driver.Navigate().GoToUrl("http://www.thefriendlytester.co.uk/p/nottstest.html");
            Driver.Navigate().Back();
            Driver.Navigate().Forward();
            Driver.Navigate().Refresh();
        }
    }
}
