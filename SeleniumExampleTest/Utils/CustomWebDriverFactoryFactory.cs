using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumExampleTest.Utils;

public class CustomWebDriverFactoryFactory : ICustomWebDriverFactory
{
    private IWebDriver _driver;
   
    public CustomWebDriverFactoryFactory()
    {
    }

    public CustomWebDriverFactoryFactory(ChromeDriver chromeDriver) => _driver = chromeDriver;

    public void GetChromeDriver()
    {
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
    
    public IWebDriver CreateFirefoxDriver2()
    {
        _driver = new FirefoxDriver();
        return _driver;
    }
    
    public void CloseChromeDriver()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}