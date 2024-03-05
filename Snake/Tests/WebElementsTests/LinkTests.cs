using OpenQA.Selenium;
using Snake.ComponentHelper;
using Snake.Configuration;

namespace Snake.Tests.NavigatorTests;

[TestClass]
public class LinkTests
{
    private readonly ConfigReader _config = new ConfigReader();
    
    [TestInitialize]
    public void Init()
    {
        NavigationHelper.NavigateToHomePage();
    }
    
    [TestMethod]
    [DataRow("New User")]
    public void ClickLinkTest(string text)
    {
        GenericHelper.GetElement(By.LinkText(text)).Click();
    }
    
    [TestMethod]
    [DataRow("New User")]
    public void ClickLinkFromHelperTest(string text)
    {
        LinkHelper.ClickLink(By.LinkText(text));
    }
    
    [TestMethod]
    [DataRow("New User")]
    public void GetLinkValueTest(string text)
    {
        var value = LinkHelper.GetLinkValue(By.LinkText(text));
        Console.WriteLine("Link value is: " + value);
    }
    
    [TestMethod]
    [DataRow("New User", true)]
    public void ClickLinkFromHelperAndVerifyTest(string text, Boolean expected = true)
    {
        string value = LinkHelper.GetLinkValue(By.LinkText(text));
        LinkHelper.ClickLink(By.LinkText(text));
        string currentUrl = PageHelper.GetPageUrl();
        Assert.AreEqual(expected, currentUrl.Contains(value));
    }
}