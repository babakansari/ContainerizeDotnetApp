using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace TestsInDocker.NUnit.UIAutomation
{
    [TestFixture]
    public class ChromeDriverTests
    {
        //private ChromeDriver _driver;
        //public TestContext TestContext { get; set; }

        //public static string CurrentAssemblyPath => TestContext.CurrentContext.TestDirectory;

        //[SetUp]
        //public void TestInitialize()
        //{
        //    Console.WriteLine(@">>>>>>>>>>>>   Initiate Chrome Driver <<<<<<<<<<<<<<<");
        //    Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"/usr/bin/chromedriver");
        //    ChromeOptions chromeOptions = new ChromeOptions();
        //    chromeOptions.AddArguments("--headless");
        //    chromeOptions.AddArguments("--no-sandbox");

        //    _driver = new ChromeDriver(chromeOptions);

        //}

        //[Test]
        //public void Chrome_Driver_Test_Execution()
        //{
        //    _driver.Manage().Window.Maximize();
        //    _driver.Navigate().GoToUrl("https://www.google.ca");
        //    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        //    Assert.IsTrue(_driver.PageSource.Contains("About"));
        //}
    }
}
