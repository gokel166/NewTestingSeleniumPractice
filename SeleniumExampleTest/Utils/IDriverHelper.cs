using OpenQA.Selenium;

namespace SeleniumExampleTest.Utils;

public interface IDriverHelper
{
    IWebDriver Driver { get; set; }
}