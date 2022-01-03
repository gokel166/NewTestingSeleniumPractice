using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExampleTest.Utils;

namespace SeleniumExampleTest.TestRuns;

[TestFixture]
public class SeleniumChromeTest
{
    // Initialize the CustomWebDriver class
    private ICustomWebDriverFactory _customDriverFactory;
    private CustomWebDriverFactory _factory;
    private IWebDriver _driver;

    [SetUp]
    public void Initialize()
    {
        _factory = _customDriverFactory as CustomWebDriverFactory;
        _factory = new CustomWebDriverFactory(new ChromeDriver());
        _driver = _factory.InitializedDriver;
    }

    [Test]
    public void TestOpenChromeBrowser()
    {
        _factory.CreateChromeDriver();
        _factory.GoToProvidedUrl("https://www.google.com");
        Thread.Sleep(1200);
    }

    [Test]
    public void GoToYoutubeHomePage()
    {
        _factory.GoToProvidedUrl("http://www.youtube.com");
        Thread.Sleep(2000);
    }
    
    [TearDown]
    public void CleanUp()
    {
        _factory.InitializedDriver.Close();
        _factory.InitializedDriver.Quit();
    }
}