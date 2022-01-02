using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.Configurations.TestConfigs;

public interface IWebDriverFactory
{
    IWebDriver CreateWebDriver(Browser browser, WindowSize windowSize, bool isLocal,
        PlatformType platformType, bool headless);

    IWebDriver GetLocalWebDriver(Browser browser, bool headless = false);
    IWebDriver GetRemoteWebDriver(Browser browser, Uri gridUrl, PlatformType platformType = PlatformType.Any);
    IWebDriver SetWindowSize(IWebDriver driver, WindowSize windowSize);
}