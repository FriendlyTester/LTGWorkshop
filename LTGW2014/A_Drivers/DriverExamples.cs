using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;

namespace LTGW2014.A_Drivers
{
    [TestClass]
    public class DriverExamples
    {
        [TestMethod]
        public void A_CreateFirefoxDriver()
        {
            var Driver = new FirefoxDriver();
            //Show FirefoxDriver examples, profile etc.
        }

        [TestMethod]
        public void A_CreateChromeDriver()
        {
            var Driver = new ChromeDriver();
            //Show ChromeOptions examples, binary proxy etc.
            Driver.Quit();
        }

        [TestMethod]
        public void A_CreateIEDriver()
        {
            var Driver = new InternetExplorerDriver();
            //var Driver = new InternetExplorerDriver(@"C:\Users\Richard\Documents\Visual Studio 2013\Projects\LTGW2014\packages\Selenium.WebDriver.IEDriver.2.43.0.0\content\");
            Driver.Quit();
        }

        public void A_CreateRemoteWebDriver()
        {
            var Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wb/hub"), DesiredCapabilities.Chrome());
            Driver.Quit();
        }
    }
}
