using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace TestsInDocker.NUnit.UIAutomation
{
    [TestFixture]
    public class ChromeDriverTests
    {
        private ChromeDriver _driver;
        public TestContext TestContext { get; set; }

        public static string CurrentAssemblyPath => TestContext.CurrentContext.TestDirectory;

        [SetUp]
        public void TestInitialize()
        {
            Console.WriteLine(@">>>>>>>>>>>>   Initiate Chrome Driver <<<<<<<<<<<<<<<");
            //Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"/usr/bin/chromedriver");
            var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--no-sandbox");

            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
            chromeOptions.Proxy = null;
            //chromeOptions.AddArgument("--start-maximized");

            chromeOptions.AddArgument("--disable-infobars");
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddUserProfilePreference("password_manager_enabled", false);


            _driver = new ChromeDriver(chromeOptions);

        }

        [Test]
        public void Chrome_Driver_Test_Execution()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.google.ca");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.IsTrue(_driver.PageSource.Contains("About"));
        }
    }
}
