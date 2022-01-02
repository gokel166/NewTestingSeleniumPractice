using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumExampleTest.TestRuns;

[TestFixture]
public class InitialSeleniumTest
{
    private IWebDriver _driver;
    
    [SetUp]
    public void Initialize()
    {
        _driver = new ChromeDriver();
    }
    
    [Test]
    public void TestMethod1()
    {
        _driver.Navigate().GoToUrl("https://youtube.com");
        Console.WriteLine("TestMethod1");
        Thread.Sleep(5000);
    }
    
    [TearDown]
    public void CleanUp()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}