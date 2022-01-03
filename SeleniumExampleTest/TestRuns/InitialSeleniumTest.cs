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
    private CustomWebDriverFactory _customDriverFactory;

    [SetUp]
    public void Initialize()
    {
        _customDriverFactory = new CustomWebDriverFactory();
    }

    [Test]
    public void TestOpenChromeBrowser()
    {
        this.OpenChromeBrowser();
        Thread.Sleep(2500);
    }

    [Test]
    public void GoToYoutubeHomePage()
    {
        // _customDriverFactory.GetDriver().FindElement()
    }

    [Test]
    public void TestOpenFirefoxBrowser()
    {
        this.OpenFirefoxBrowser();
        Thread.Sleep(2500);
    }
    
    [TearDown]
    public void CleanUp()
    {
        _customDriverFactory.CloseWebDriver();
    }

    private void OpenChromeBrowser()
    {
        _customDriverFactory.CreateChromeDriver().Navigate().GoToUrl("http://www.google.com");
    }
    
    private void OpenFirefoxBrowser()
    {
        _customDriverFactory.CreateFirefoxDriver().Navigate().GoToUrl("http://www.google.com");
    }
}