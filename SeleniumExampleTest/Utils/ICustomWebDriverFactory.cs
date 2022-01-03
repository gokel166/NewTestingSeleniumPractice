using OpenQA.Selenium;

namespace SeleniumExampleTest.Utils;

public interface ICustomWebDriverFactory
{
    IWebDriver CreateChromeDriver();
}