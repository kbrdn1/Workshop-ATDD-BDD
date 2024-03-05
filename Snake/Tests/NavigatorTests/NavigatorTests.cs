using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Snake.BaseClasses;
using Snake.Configuration;
using Snake.Interfaces;

namespace Snake.Tests.NavigatorTests;

[TestClass]
public class NavigatorTests
{
    [TestMethod]
    public void OpenChromeAndGoToHomePage()
    {
        IWebDriver driver = new ChromeDriver();
        IConfig config = new ConfigReader();
        driver.Navigate().GoToUrl(config.GetWebsite());
        driver.Close();
        driver.Quit();
    }
    
    [TestMethod]
    public void OpenFirefoxAndGoToHomePage()
    {
        IWebDriver driver = new FirefoxDriver();
        IConfig config = new ConfigReader();
        driver.Navigate().GoToUrl(config.GetWebsite());
        driver.Close();
        driver.Quit();
    }
    
    [TestMethod]
    [Ignore] // Internet Explorer is not supported on Linux
    public void OpenInternetExplorerAndGoToHomePage()
    {
        IWebDriver driver = new InternetExplorerDriver();
        IConfig config = new ConfigReader();
        driver.Navigate().GoToUrl(config.GetWebsite());
        driver.Close();
        driver.Quit();
    }
    
    [TestMethod]
    public void OpenConfigBrowserWithBaseClass()
    {
        Console.WriteLine("Browser : " + ObjectRepository.Config.GetWebsite());
    }
}