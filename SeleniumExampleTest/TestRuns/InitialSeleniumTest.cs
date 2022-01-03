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
    private CustomWebDriverFactoryFactory _customDriverFactoryFactory;

    [SetUp]
    public void Initialize()
    {
        _customDriverFactoryFactory = new CustomWebDriverFactoryFactory();
    }
    
    [Test]
    public void TestOpenNewBrowser()
    {
        _customDriverFactoryFactory.CreateFirefoxDriver().Navigate().GoToUrl("http://www.google.com");
        Thread.Sleep(2500);
    }
    
    [TearDown]
    public void CleanUp()
    {
        _customDriverFactoryFactory.CloseChromeDriver();
    }
}