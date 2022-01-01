using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.PageObjects.HomePages;

public class HomePage
{
    private IWebDriver _driver;

    public HomePage()
    {
    }

    public HomePage(IWebDriver driver)
    {
        this._driver = driver;
    }

    public void SuccessfullyOpenChromeBrowser()
    {
        this._driver.Navigate().GoToUrl("https://udemy.com");
    }
}