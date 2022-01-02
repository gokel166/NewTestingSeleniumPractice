using NewTest.SeleniumExampleTest.Configurations.TestConfigs;
using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.Configurations;

public class WebDriverManager : IWebDriverManager
{
    private IWebDriver _driver;
    private readonly Func<IWebDriver> _webDriverConstructor;

    public WebDriverManager()
    {
    }

    public WebDriverManager(IWebDriverFactory factory, IWebDriverConfiguration configuration)
    {
        this._webDriverConstructor = () => factory.GetWebDriver(configuration);
    }
    
    public WebDriverManager(IWebDriverFactory factory, Browser browser, WindowSize windowSize = WindowSize.Hd, bool isLocal = true, PlatformType platformType = PlatformType.Any, bool headless = false)
    {
        this._webDriverConstructor = () => factory.CreateWebDriver(browser, windowSize, isLocal, platformType, headless);
    }

    public IWebDriver Driver
    {
        get => _driver ?? (_driver = _webDriverConstructor());
        private set => _driver = value;
    }

    public virtual IWebDriver Get() => _driver;

    public virtual IWebDriver Quit()
    {
        if (_driver != null)
        {
            _driver.Quit();
            _driver = null;
        }
        
        return _driver;
    }

    public virtual IWebDriver GetAdditionalWebDriver()
    {
        return _webDriverConstructor();
    }
}