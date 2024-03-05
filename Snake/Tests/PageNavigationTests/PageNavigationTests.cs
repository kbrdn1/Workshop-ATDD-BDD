using Snake.BaseClasses;
using Snake.ComponentHelper;

namespace Snake.Tests.PageNavigationTests;

[TestClass]
public class PageNavigationTests
{
    [TestMethod]
    public void OpenPageFromDriver()
    {
        ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
    }

    [TestMethod]
    public void OpenPageFromObjectRepository()
    {
        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
    }

    [TestMethod]
    public void OpenPageFromObjectRepositoryAndGetTitle()
    {
        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        Console.WriteLine(ObjectRepository.Driver.Title);
    }

    [TestMethod]
    public void OpenPageFromObjectRepositoryAndGetTitleFromPageHelper()
    {
        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        Console.WriteLine(PageHelper.GetPageTitle());
    }
}