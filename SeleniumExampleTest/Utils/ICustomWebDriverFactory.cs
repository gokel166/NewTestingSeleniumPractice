using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumExampleTest.Utils;

public interface ICustomWebDriverFactory
{
    IWebDriver InitializedDriver { get; }
    IWebDriver GetChromeDriver(ChromeDriver chromeDriver);
    IWebDriver GetFireFoxDriver(FirefoxDriver firefoxDriver);
    void CloseWebDriver();
    IWebDriver CreateFirefoxDriver();
    void GoToProvidedUrl(string url);
}

// Create interface ICustomWebDriverFactory that takes Generic type of T inherits from IWebDriver
public interface ICustomWebDriverFactory<T> where T : IWebDriver
{
    IWebDriver CreateWebDriver<T>();
}