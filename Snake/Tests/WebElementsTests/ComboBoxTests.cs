using OpenQA.Selenium;
using Snake.ComponentHelper;
using Snake.Configuration;

namespace Snake.Tests.WebElementsTests;

[TestClass]
public class ComboBoxTests
{
    private readonly ConfigReader _config = new ConfigReader();
    
    [TestMethod]
    [DataRow("security_level")]
    public void GetComboBoxValueTest(string name)
    {
        NavigationHelper.NavigateToHomePage();
        string value = ComboBoxHelper.GetSelectedElement(By.Name(name));
        Assert.AreEqual("low", value);
    }
    
    [TestMethod]
    [DataRow("security_level", "low")]
    [DataRow("security_level", "medium")]
    [DataRow("security_level", "high")]
    public void ComboBoxTest(string name, string value)
    {
        NavigationHelper.NavigateToHomePage();
        ComboBoxHelper.SelectElement(By.Name(name), value);
        string selectedValue = ComboBoxHelper.GetSelectedElement(By.Name(name));
        Assert.AreEqual(value, selectedValue);
    }
}