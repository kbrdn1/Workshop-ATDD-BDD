using Snake.BaseClasses;

namespace Snake.ComponentHelper;

public class NavigationHelper
{
    public static void NavigateToUrl(string url)
    {
        ObjectRepository.Driver?.Navigate().GoToUrl(url);
    }

    public static void NavigateToHomePage()
    {
        ObjectRepository.Driver?.Navigate().GoToUrl(ObjectRepository.Config?.GetWebsite());
    }
}