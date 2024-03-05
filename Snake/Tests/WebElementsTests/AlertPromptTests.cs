using Snake.ComponentHelper;

namespace Snake.Tests.WebElementsTests;

[TestClass]
public class AlertPromptTests
{
    [TestInitialize]
    public void Init()
    {
        NavigationHelper.NavigateToHomePage();
        AlertHelper.CreatePrompt("This is an prompt alert");
    }
    
    [TestCleanup]
    public void CleanUp()
    {
        if (AlertHelper.AlertIsPresent())
        {
            AlertHelper.DismissAlert();
        }
    }
    
    [TestMethod]
    public void GetAlertTextTest()
    {
        string alertText = AlertHelper.GetAlertText();
        Assert.AreEqual("This is an prompt alert", alertText);
    }
    
    [TestMethod]
    public void AcceptAlertTest()
    {
        string alertText = AlertHelper.GetAlertText();
        Assert.AreEqual("This is an prompt alert", alertText);
        AlertHelper.AcceptAlert();
    }
    
    [TestMethod]
    public void DismissAlertTest()
    {
        string alertText = AlertHelper.GetAlertText();
        Assert.AreEqual("This is an prompt alert", alertText);
        AlertHelper.DismissAlert();
    }
    
    [TestMethod]
    public void SendKeysToAlertTest()
    {
        string alertText = AlertHelper.GetAlertText();
        Assert.AreEqual("This is an prompt alert", alertText);
        AlertHelper.SendKeysToAlert("Hello");
        AlertHelper.AcceptAlert();
    }
}
