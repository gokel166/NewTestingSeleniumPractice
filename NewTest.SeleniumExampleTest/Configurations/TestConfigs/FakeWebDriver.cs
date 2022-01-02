using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace NewTest.SeleniumExampleTest.Configurations.TestConfigs;

public class FakeWebDriver : IWebDriver
{
    public void Close()
    {
        throw new NotImplementedException();
    }

    public void Quit()
    {
        throw new NotImplementedException();
    }
    
    public IOptions Manage()
    {
        throw new NotImplementedException();
    }

    public INavigation Navigate()
    {
        throw new NotImplementedException();
    }

    public ITargetLocator SwitchTo()
    {
        throw new NotImplementedException();
    }

    public string Url { get; set; }
    public string Title { get; set; }
    public string PageSource { get; set; }
    public string CurrentWindowHandle { get; }
    public ReadOnlyCollection<string> WindowHandles { get; }

    public IWebElement FindElement(By by)
    {
        throw new NotImplementedException();
    }

    public ReadOnlyCollection<IWebElement> FindElements(By by)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}