using Microsoft.Extensions.Configuration;
using Snake.CustomExceptions;
using Snake.Interfaces;
using Snake.Settings;

namespace Snake.Configuration;

public class ConfigReader : IConfig
{
    private readonly GameSettings? _settings;
    
    public ConfigReader()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        _settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
    }

    public BrowserType GetBrowser()
    {
        string browser = _settings.Browser;

        try
        {
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }
        catch (ArgumentException)
        {
            throw new NoSuitableDriverFound("Aucun driver n'a été trouvé  : " + _settings.Browser);
        }
    }

    public string GetUsername()
    {
        return _settings?.Username ?? throw new ArgumentNullException(nameof(_settings));
    }

    public string GetPassword()
    {
        return _settings?.Password ?? throw new ArgumentNullException(nameof(_settings));
    }
    
    public string GetWebsite()
    {
        return _settings?.Website ?? throw new ArgumentException(nameof(_settings));
    }
    
    public SecurityLevelType GetSecurityLevel()
    {
        string securityLevel = _settings?.SecurityLevel ?? throw new ArgumentNullException(nameof(_settings));

        try
        {
            return (SecurityLevelType)Enum.Parse(typeof(SecurityLevelType), securityLevel);
        }
        catch (ArgumentException)
        {
            throw new NoSuitableDriverFound("Aucun niveau de sécurité n'a été trouvé : " + _settings.SecurityLevel);
        }
    }
}