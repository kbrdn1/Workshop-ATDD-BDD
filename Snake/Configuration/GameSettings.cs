namespace Snake.Configuration;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.Json;

public class GameSettings
{
    public string Browser { get; set; }
    
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string Website { get; set; }
    
    public string SecurityLevel { get; set; }
}