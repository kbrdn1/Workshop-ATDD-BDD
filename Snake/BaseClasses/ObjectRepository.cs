using OpenQA.Selenium;
using Snake.Interfaces;

namespace Snake.BaseClasses;

public class ObjectRepository
{
    public static IConfig? Config { get; set; }
    public static IWebDriver? Driver { get; set; }
}