using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Snake.BaseClasses;

namespace Snake.ComponentHelper;

public class AlertHelper
{
    public static string GetAlertText()
    {
        if (ObjectRepository.Driver != null)
            return ObjectRepository.Driver.SwitchTo().Alert().Text;
        return string.Empty;
    }
    
    public static void AcceptAlert()
    {
        ObjectRepository.Driver?.SwitchTo().Alert().Accept();
    }
    
    public static void DismissAlert()
    {
        ObjectRepository.Driver?.SwitchTo().Alert().Dismiss();
    }
    
    public static void SendKeysToAlert(string text)
    {
        ObjectRepository.Driver?.SwitchTo().Alert().SendKeys(text);
    }
    
    public static void CreateAlert(string text)
    {
        IJavaScriptExecutor? js = (IJavaScriptExecutor)ObjectRepository.Driver!;
        js.ExecuteScript("alert('" + text + "')");
    }
    
    public static void CreateConfirm(string text)
    {
        IJavaScriptExecutor? js = (IJavaScriptExecutor)ObjectRepository.Driver!;
        js.ExecuteScript("confirm('" + text + "')");
    }
    
    public static void CreatePrompt(string text)
    {
        IJavaScriptExecutor? js = (IJavaScriptExecutor)ObjectRepository.Driver!;
        js.ExecuteScript("prompt('" + text + "')");
    }
    
    public static bool AlertIsPresent()
    {
        WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(1));
        try
        {
            wait.Until(d => ObjectRepository.Driver?.SwitchTo().Alert());
            return true;
        }
        catch (WebDriverTimeoutException)
        {
            return false;
        }
    }
}