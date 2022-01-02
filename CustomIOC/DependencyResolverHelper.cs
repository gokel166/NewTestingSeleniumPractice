using OpenQA.Selenium;

namespace CustomIOC;

public class DependencyResolverHelper
{
    private readonly IWebDriver _webDriver;

    public DependencyResolverHelper(IWebDriver webDriver) => _webDriver = webDriver;

    public T GetService<T>()
    {
        return (T)_webDriver;
    }
}