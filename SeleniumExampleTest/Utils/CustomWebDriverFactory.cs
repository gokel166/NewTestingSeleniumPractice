using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumExampleTest.Utils;

public class CustomWebDriverFactory : ICustomWebDriverFactory
{
    private IWebDriver _driver;
   
    public CustomWebDriverFactory() : base()
    {
    }
    
    // Create a method with the instance of current driver referenced by _driver
    public IWebDriver GetDriver()
    {
        if (_driver == null)
        {
            _driver = new ChromeDriver();
        }
        return _driver;
    }
    
    // Create a factory method for ChromeDriver
    public IWebDriver CreateChromeDriver()
    {
        _driver = new ChromeDriver();
        return _driver;
    }
    
    public IWebDriver CreateFirefoxDriver()
    {
        _driver = new FirefoxDriver();
        return _driver;
    }
    
    public void CloseWebDriver()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}

// Create an extension class for CustomWebDriverFactory with method to extend to IWebDriver
public static class CustomWebDriverFactoryExtensions
{
    public static void CloseChromeDriver(this CustomWebDriverFactory factory)
    {
        factory.GetDriver().Quit();
        factory.GetDriver().Dispose();
    }
}