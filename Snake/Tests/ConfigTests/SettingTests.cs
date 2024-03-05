using Microsoft.Extensions.Configuration;
using Snake.Configuration;

namespace Snake.Tests.ConfigTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SettingTests
{
    private GameSettings? _settings;

    [TestInitialize]
    public void Init()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        _settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>() ?? throw new InvalidOperationException();
    }

    [TestMethod]
    public void GetBrowserFromConfig()
    {
        Console.WriteLine($"Browser = { _settings?.Browser }");
    }

    [TestMethod]
    public void GetUsernameFromConfig()
    {
        Console.WriteLine($"Username = { _settings?.Username }");
    }

    [TestMethod]
    public void GetPasswordFromConfig()
    {
        Console.WriteLine($"Password = { _settings?.Password }");
    }

    [TestMethod]
    public void GetWebsiteFromConfig()
    {
        Console.WriteLine($"Website = { _settings?.Website }");
    }
}