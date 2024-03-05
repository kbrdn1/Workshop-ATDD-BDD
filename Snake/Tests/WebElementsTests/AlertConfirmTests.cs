using Snake.ComponentHelper;

namespace Snake.Tests.WebElementsTests;

[TestClass]
public class AlertConfirmTests
{
    [TestInitialize]
    public void Init()
    {
        NavigationHelper.NavigateToHomePage();
        AlertHelper.CreateConfirm("This is an confirm alert");
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
        Assert.AreEqual("This is an confirm alert", alertText);
    }
    
    [TestMethod]
    public void AcceptAlertTest()
    {
        string alertText = AlertHelper.GetAlertText();
        Assert.AreEqual("This is an confirm alert", alertText);
        AlertHelper.AcceptAlert();
    }
}