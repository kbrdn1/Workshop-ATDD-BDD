using Snake.ComponentHelper;
using Snake.Configuration;

namespace Snake.Tests.WebElementsTests;

[TestClass]
public class PageTests
{
    private readonly ConfigReader _config = new ConfigReader();
    [TestMethod]
    public void NavigateToHomePageTest()
    {
        NavigationHelper.NavigateToHomePage();
        string url = PageHelper.GetPageUrl();
        Assert.IsTrue(url.Contains("login.php"));
    }
    
    [TestMethod]
    public void NavigateToNewUserPageTest()
    {
        NavigationHelper.NavigateToUrl(_config.GetWebsite() + "user_new.php");
        string url = PageHelper.GetPageUrl();
        Assert.IsTrue(url.Contains("user_new.php"));
    }
    
    [TestMethod]
    public void NavigateToTrainingPageTest()
    {
        NavigationHelper.NavigateToUrl(_config.GetWebsite() + "training.php");
        string url = PageHelper.GetPageUrl();
        Assert.IsTrue(url.Contains("training.php"));
    }
}