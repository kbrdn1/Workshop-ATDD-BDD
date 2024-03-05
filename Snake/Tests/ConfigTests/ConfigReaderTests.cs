using Snake.Configuration;
using Snake.Interfaces;
using Snake.BaseClasses;

namespace Snake.Tests.ConfigTests;

[TestClass]
public class ConfigReaderTests
{
    [TestMethod]
    public void GetSettingsKeysFromConfigReader()
    {
        IConfig config = new ConfigReader();
        Console.WriteLine("Browser : " + config.GetBrowser());
        Console.WriteLine("Username : " + config.GetUsername());
        Console.WriteLine("Password : " + config.GetPassword());
        Console.WriteLine("Website : " + config.GetWebsite());
    }
    
    [TestMethod]
    public void GetConfigReaderFromObjectRepository()
    {
        Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
        Console.WriteLine("Username : " + ObjectRepository.Config.GetUsername());
        Console.WriteLine("Password : " + ObjectRepository.Config.GetPassword());
        Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
    }
}