using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumExampleTest.Utils;

public interface IDriverHelper
{
    EdgeDriver OpenEdgeBrowser();
    ChromeDriver OpenChromeBrowser();
}