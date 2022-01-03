using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExampleTest.Utils;

namespace SeleniumExampleTest.TestRuns;

[TestFixture]
public class SeleniumFirefoxTests
{
    private ICustomWebDriverFactory _customWebDriverFactory;
    private CustomWebDriverFactory _factory;
    private IWebDriver _driver;

    public SeleniumFirefoxTests()
    {
    }
    
    [SetUp]
    public void Setup()
    {
        _factory = _customWebDriverFactory as CustomWebDriverFactory;
        _factory = new CustomWebDriverFactory(new FirefoxDriver());
        _driver = _factory.InitializedDriver;
    }

    [Test]
    public void OpenBrowser()
    {
        _factory.CreateFirefoxDriver();
        _factory.GoToProvidedUrl("http://www.google.com");
        Thread.Sleep(1200);
    }
    
    [Test]
    public void OpenYoutube()
    {
        _factory.GoToProvidedUrl("http://www.youtube.com");
        Thread.Sleep(2000);
    }
    
    [TearDown]
    public void CleanUp()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}