using OpenQA.Selenium;
using Snake.Configuration;

namespace Snake.ComponentHelper;

[TestClass]
public class ButtonTests
{
    [TestInitialize]
    public void Init()
    {
        NavigationHelper.NavigateToHomePage();
        TextBoxHelper.TypeInTextBox(By.Id("login"), "username");
        TextBoxHelper.TypeInTextBox(By.Id("password"), "password");
    }
    
    [TestMethod]
    [DataRow("login")]
    public void ClickOnButtonTest(string name)
    {
        GenericHelper.GetElement(By.Name(name)).Click();
    }
    
    [TestMethod]
    [DataRow("login")]
    public void ClickOnButtonFromHelperTest(string name)
    {
        ButtonHelper.ClickButton(By.Name(name));
    }
}