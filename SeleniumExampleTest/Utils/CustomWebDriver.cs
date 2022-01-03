using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumExampleTest.Utils;

public class CustomWebDriver : ICustomWebDriver
{
    private IWebDriver _driver;
    public CustomWebDriver(ChromeDriver chromeDriver)
    {
        _driver = chromeDriver;
    }

    public void GetChromeDriver()
    {
    }

    // Create a factory method for ChromeDriver
    public IWebDriver CreateChromeDriver()
    {
        return _driver;
    }
    
    public IWebDriver CloseChromeDriver()
    {
        _driver.Quit();
        return _driver;
    }
}