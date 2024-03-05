using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Snake.BaseClasses;

namespace Snake.ComponentHelper;

public class GenericHelper
{
    public static bool IsElementPresentOnce(By locator)
    {
        try
        {
            return ObjectRepository.Driver?.FindElements(locator).Count == 1;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public static bool IsElementPresentAtLeastOnce(By locator)
    {
        try
        {
            return ObjectRepository.Driver?.FindElements(locator).Count > 1;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static IWebElement GetElement(By locator)
    {
        if (IsElementPresentOnce(locator) && ObjectRepository.Driver != null)
            return ObjectRepository.Driver.FindElement(locator);
        else
            throw new NoSuchElementException("Element not found" + locator.ToString());
    }
    
    public static ReadOnlyCollection<IWebElement> GetElements(By locator)
    {
        if (IsElementPresentAtLeastOnce(locator) && ObjectRepository.Driver != null)
            return ObjectRepository.Driver.FindElements(locator);
        else
            throw new NoSuchElementException("Element not found" + locator.ToString());
    }
}