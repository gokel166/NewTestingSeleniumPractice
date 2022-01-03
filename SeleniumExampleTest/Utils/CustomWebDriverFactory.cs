using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumExampleTest.Utils;

public class CustomWebDriverFactory : ICustomWebDriverFactory
{
    private IWebDriver _driver;

    public CustomWebDriverFactory() : base()
    {
    }
    
    public CustomWebDriverFactory(ChromeDriver driver) 
    {
        _driver = driver;
    }
    
    public CustomWebDriverFactory(FirefoxDriver driver)
    {
        _driver = driver;
    }
    
    // create property InitalizedDriver which get value of _driver after checking for not null condition
    public IWebDriver InitializedDriver
    {
        get
        {
            if (_driver == null)
            {
                throw new NullReferenceException("The WebDriver browser instance was not initialized.");
            }
            return _driver;
        }
        set => _driver = value;
    }

    public IWebDriver GetChromeDriver(ChromeDriver chromeDriver)
    {
        _driver = chromeDriver;
        return _driver;
    }

    public IWebDriver GetFireFoxDriver(FirefoxDriver firefoxDriver)
    {
        _driver = firefoxDriver;
        return _driver;
    }

    public void CloseWebDriver()
    {
        _driver.Close();
        _driver.Quit();
    }

    public IWebDriver CreateFirefoxDriver()
    {
        _driver = new FirefoxDriver();
        return _driver;
    }

    public IWebDriver CreateChromeDriver()
    {
        _driver = new ChromeDriver();
        return _driver;
    }
    
    public void GoToProvidedUrl(string url)
    {
        _driver.Navigate().GoToUrl(url);
    }

    public CustomWebDriverFactory GetCurrentDriverType()
    {
        if (_driver == null)
        {
            throw new ArgumentException("The WebDriver browser instance was not initialized.");
        }
        return this;
    }
    
    public CustomWebDriverFactory GetCurrentDriverType(ChromeDriver chromeDriver)
    {
        if (_driver == null)
        {
            _driver = new ChromeDriver();;
        }
        return this;
    }
}