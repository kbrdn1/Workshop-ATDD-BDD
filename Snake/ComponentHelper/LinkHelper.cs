using OpenQA.Selenium;

namespace Snake.ComponentHelper;

public class LinkHelper
{
    public static void ClickLink(By locator)
    {
        GenericHelper.GetElement(locator).Click();
    }
    
    public static string GetLinkValue(By locator)
    {
        return GenericHelper.GetElement(locator).GetAttribute("href");
    }
}