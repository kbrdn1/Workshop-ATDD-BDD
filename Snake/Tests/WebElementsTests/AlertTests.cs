using Snake.ComponentHelper;

namespace Snake.Tests.WebElementsTests;

[TestClass]
public class AlertTests
{
    [TestInitialize]
    public void Init()
    {
        NavigationHelper.NavigateToHomePage();
        AlertHelper.CreateAlert("This is an alert");
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
        Assert.AreEqual("This is an alert", alertText);
    }
    
    [TestMethod]
    public void AcceptAlertTest()
    {
        string alertText = AlertHelper.GetAlertText();
        Assert.AreEqual("This is an alert", alertText);
        AlertHelper.AcceptAlert();
    }
    
    [TestMethod]
    public void DismissAlertTest()
    {
        string alertText = AlertHelper.GetAlertText();
        Assert.AreEqual("This is an alert", alertText);
        AlertHelper.DismissAlert();
    }
}