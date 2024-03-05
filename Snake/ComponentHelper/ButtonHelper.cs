using OpenQA.Selenium;

namespace Snake.ComponentHelper;

public class ButtonHelper
{
    public static void ClickButton(By locator)
    {
        GenericHelper.GetElement(locator).Click();
    }
}