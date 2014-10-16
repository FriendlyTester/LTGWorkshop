using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGW2014.E_Examples
{
    [TestClass]
    public class CrossBrowserScreenshots
    {
        [TestMethod]
        public void F_ExecuteScreenshots()
        {
            TakeScreenshotChrome();
            TakeScreenshotFirefox();
        }

        private void TakeScreenshotFirefox()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http://thefriendlytester.co.uk");
            var screenshot = Driver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\Richard\Desktop\LTGW2014\FirefoxScreenshot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Driver.Quit();
        }

        private void TakeScreenshotChrome()
        {
            var Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://thefriendlytester.co.uk");
            var screenshot = Driver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\Richard\Desktop\LTGW2014\ChromeScreenshot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Driver.Quit();
        }
    }
}
