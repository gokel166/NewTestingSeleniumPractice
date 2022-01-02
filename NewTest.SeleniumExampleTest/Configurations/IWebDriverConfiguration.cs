using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.Configurations;

public interface IWebDriverConfiguration
{
    Browser Browser { get; set; }
    PlatformType PlatformType { get; set; }
    WindowSize WindowSize { get; set; }
    Uri GridUri { get; set; }
    bool IsLocal { get; set; }
    bool Headless { get; set; }
}