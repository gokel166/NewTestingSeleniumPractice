using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewTest.SeleniumExampleTest.TestRuns;

[TestFixture]
public class WebDriverLauncherTests
{
    private readonly string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    [Test]
    public void ChromeDriverCanBeLaunched()
    {
        IWebDriver driver = new ChromeDriver(driverPath);
        AssertThatTheWebDriverHasLoadedAPage(driver);
    }
    
    private void AssertThatTheWebDriverHasLoadedAPage(IWebDriver driver)
    {
        driver.Url = "";
        var t = driver.Title;
        t.Should();
        driver.Title.Should().NotBeNullOrEmpty();
        driver.Quit();
    }
}