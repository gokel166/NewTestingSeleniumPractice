using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumExampleTest.Utils;

public class DriverHelper
{
    public EdgeDriver OpenEdgeBrowser()
    {
        return new EdgeDriver();
    }

    public ChromeDriver OpenChromeBrowser()
    {
        return new ChromeDriver();
    }
}