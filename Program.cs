using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumHubTestBench
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var wd = new OpenQA.Selenium.Remote.RemoteWebDriver(new Uri("http://172.31.0.240:4444/wd/hub"), DesiredCapabilities.Chrome()))
            {
                wd.Url = ("http://www.google.com");
                wd.Navigate();
                Screenshot screenshot = ((ITakesScreenshot)wd).GetScreenshot();
                screenshot.SaveAsFile("Test.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                wd.Quit();
            }
        }
    }
}
