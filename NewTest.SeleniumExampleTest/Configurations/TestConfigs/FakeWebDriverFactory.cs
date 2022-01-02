using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.Configurations.TestConfigs;

public class FakeWebDriverFactory : IWebDriverFactory
{
    public IWebDriver CreateWebDriver(Browser browser, WindowSize windowSize, bool isLocal, PlatformType platformType,
        bool headless)
    {
        throw new NotImplementedException();
    }

    public IWebDriver GetLocalWebDriver(Browser browser, bool headless = false)
    {
        throw new NotImplementedException();
    }

    public IWebDriver GetRemoteWebDriver(Browser browser, Uri gridUrl, PlatformType platformType = PlatformType.Any)
    {
        throw new NotImplementedException();
    }

    public IWebDriver SetWindowSize(IWebDriver driver, WindowSize windowSize)
    {
        throw new NotImplementedException();
    }
}