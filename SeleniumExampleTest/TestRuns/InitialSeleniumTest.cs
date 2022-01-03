using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExampleTest.Utils;

namespace SeleniumExampleTest.TestRuns;

[TestFixture]
public class InitialSeleniumTest
{
    // Initialize the CustomWebDriver class
    private CustomWebDriver CustomDriver;

    [SetUp]
    public void Initialize()
    {
        CustomDriver = new CustomWebDriver(new ChromeDriver());
    }
    
    [Test]
    public void TestOpenNewBrowser()
    {
        CustomDriver.CreateChromeDriver().Navigate().GoToUrl("https:www.google.com");
        Thread.Sleep(2500);
    }
    
    [TearDown]
    public void CleanUp()
    {
        CustomDriver.CloseChromeDriver();
    }
}