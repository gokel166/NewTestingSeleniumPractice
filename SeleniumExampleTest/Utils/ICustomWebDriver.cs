using OpenQA.Selenium;

namespace SeleniumExampleTest.Utils;

public interface ICustomWebDriver
{
    IWebDriver CreateChromeDriver();
}