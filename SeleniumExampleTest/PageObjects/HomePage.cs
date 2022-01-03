using OpenQA.Selenium;
using SeleniumExampleTest.Utils;

namespace SeleniumExampleTest.PageObjects;

public class HomePage
{
    private CustomWebDriverFactory _customWebDriverFactory;
    
    // create a method for click on a button element
    public void ClickOnButton(string buttonName)
    {
        _customWebDriverFactory = new CustomWebDriverFactory();
        _customWebDriverFactory.GetDriver().FindElement(By.XPath("//button[contains(text(),'" + buttonName + "')]")).Click();
    }
}