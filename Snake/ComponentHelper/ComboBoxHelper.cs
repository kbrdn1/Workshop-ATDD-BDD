using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Snake.ComponentHelper;

public class ComboBoxHelper
{
    public static void SelectElement(By locator, string value)
    {
        IWebElement element = GenericHelper.GetElement(locator);
        var selectElement = new SelectElement(element);
        selectElement.SelectByText(value);
    }
    
    public static string GetSelectedElement(By locator)
    {
        IWebElement element = GenericHelper.GetElement(locator);
        var selectElement = new SelectElement(element);
        return selectElement.SelectedOption.Text;
    }
}