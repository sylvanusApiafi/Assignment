using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Assignment2.Utilities
{
    [Binding]
    public class Hooks1
    {
        public ChromeDriver driver;
        public FirefoxDriver driverFirefox;
        public  InternetExplorerDriver driverIE;

        [BeforeScenario]
        public void BeforeScenario()
        {
            // ChromeDriver driver = new ChromeDriver();
            driver = new ChromeDriver();
            driverFirefox = new FirefoxDriver();
            driverIE = new InternetExplorerDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();

            driverFirefox.Quit();

            driverIE.Quit();
        }
    }
}
