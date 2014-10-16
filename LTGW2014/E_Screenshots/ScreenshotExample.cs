using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGW2014.D_Screenshots
{
    [TestClass]
    public class ScreenshotExample
    {
        [TestMethod]
        public void E_TakeAScreenshot()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("http://www.twitter.com");

            var screenShot = Driver.GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\Richard\Desktop\twitter.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}