using Snake.Configuration;
using Snake.Settings;

namespace Snake.Interfaces;

public interface IConfig
{
    public BrowserType GetBrowser();
    
    public string GetUsername();
    
    public string GetPassword();
    
    public string GetWebsite();
    
    public SecurityLevelType GetSecurityLevel();
}