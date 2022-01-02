using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.Configurations;

public interface IWebDriverManager
{
    IWebDriver Get();
    
    IWebDriver Quit();
    
    IWebDriver GetAdditionalWebDriver();
}