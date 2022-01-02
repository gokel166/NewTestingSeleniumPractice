using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Drawing;

namespace NewTest.SeleniumExampleTest.Configurations;

public static class StaticWebDriverFactory
{
    public static string DriverPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    public static IWebDriver GetLocalWebDriver(Browser browser, bool headless = false)
    {
        if (headless && !(browser == Browser.Chrome || browser == Browser.Firefox))
        {
            throw ArgumentException($"Headless mode is not currently supported for {browser}");
        }

        switch (browser)
        {
            case Browser.FireFox:
                return GetLocalWebDriver(StaticDriverOptionsFactory.GetFirefoxDriverOptions(headless));
            case Browser.Chrome:
                return GetLocalWebDriver(StaticDriverOptionsFactory.GetChromeDriverOptions(headless));
            case Browser.Edge:
                return GetLocalWebDriver(StaticDriverOptionsFactory.GetEdgeDriverOptions(headless));
            default:
                throw new PlatformNotSupportedException($"{browser} is not currently supported");
        }
    }

    public static IWebDriver GetLocalWebDriver(ChromeOptions options, WindowSize windowSize = WindowSize.Hd)
    {
        IWebDriver driver = new ChromeDriver(DriverPath, options);
        return SetWindowSize(driver, windowSize);
    }

    public static IWebDriver GetRemoteWebDriver(
        Browser browser,
        Uri gridUrl,
        PlatformType platformType = PlatformType.Any)
    {
        switch (browser)
        {
            case Browser.Firefox:
                return GetRemoteWebDriver(StaticDriverOptionsFactory.GetFirefoxOptions(platformType),
                    gridUrl);

            case Browser.Chrome:
                return GetRemoteWebDriver(StaticDriverOptionsFactory.GetChromeOptions(platformType, gridUrl));

            case Browser.InternetExplorer:
                return GetRemoteWebDriver(StaticDriverOptionsFactory.GetInternetExplorerOptions(platformType),
                    gridUrl);

            case Browser.Edge:
                return GetRemoteWebDriver(StaticDriverOptionsFactory.GetEdgeOptions(platformType, gridUrl));

            case Browser.Safari:
                return GetRemoteWebDriver(StaticDriverOptionsFactory.GetSafariOptions(platformType, gridUrl));

            default:
                throw new PlatformNotSupportedException($"{browser} is not currently supported.");
        }
    }

    public static IWebDriver SetWindowSize(IWebDriver driver, WindowSize windowSize)
    {
        switch (windowSize)
        {
            case WindowSize.Unchanged:
                return driver;

            case WindowSize.Maximize:
                driver.Manage().Window.Maximize();
                return driver;

            case WindowSize.Hd:
                driver.Manage().Window.Position = Point.Empty;
                driver.Manage().Window.Size = new Size(1366, 768);
                return driver;

            case WindowSize.Fhd:
                driver.Manage().Window.Position = Point.Empty;
                driver.Manage().Window.Size = new Size(1920, 1080);
                return driver;

            case WindowSize.Uhd4K:
                driver.Manage().Window.Position = Point.Empty;
                driver.Manage().Window.Size = new Size(3840, 2160);
                return driver;

            default:
                return driver;
        }
    }
}