using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestsInDocker.NUnit.UIAutomation
{
    [TestFixture]
    public class SeleniumTests
    {
        private RemoteWebDriver _driver;
        public TestContext TestContext { get; set; }

        [SetUp]
        public void TestInitialize()
        {
            var options = new ChromeOptions();
            //options.AddArguments("--incognito");
            //options.AddUserProfilePreference("download.default_directory", @"D:\tmp");
            //options.AddUserProfilePreference("download.prompt_for_download", false);
            //options.AddUserProfilePreference("disable-popup-blocking", "true");
            //chrome_options.add_argument('--disable-dev-shm-usage')

            // To run tests on your local machine web driver
            // var driver = new ChromeDriver("../../../chromedriver78/", options);
            // var remoteWebDriverUrl = (string)TestContext.Properties["remoteWebDriverUrl"];

            var remoteWebDriverUrl = "http://localhost:4444/wd/hub";
            _driver = new RemoteWebDriver(new Uri(remoteWebDriverUrl), options);
        }

        [Test]
        public void Remote_Test_Execution()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.google.com/search?q=babak+ansari+toronto");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.IsTrue(_driver.PageSource.Contains("Babak Ansari"));
        }
    }
}
