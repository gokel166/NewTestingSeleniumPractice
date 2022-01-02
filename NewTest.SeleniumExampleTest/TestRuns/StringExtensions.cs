using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.TestRuns;

public static class StringExtensions
{
    // Create extension method of IWebDriver instance.Title()
    public static string Title(this IWebDriver driver)
    {
        return driver.Title;
    }
}