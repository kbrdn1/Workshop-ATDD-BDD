using OpenQA.Selenium;
using Snake.Configuration;

namespace Snake.ComponentHelper;

[TestClass]
public class TextBoxTests
{
    private readonly ConfigReader _config = new ConfigReader();
    
    [TestInitialize]
    public void Init()
    {
        NavigationHelper.NavigateToHomePage();
    }
    
    [TestMethod]
    [DataRow("login", "username")]
    public void TextBoxTest(string id, string text)
    {
        var textBox = GenericHelper.GetElement(By.Id(id));
        textBox.SendKeys(text);
        ClearTextBoxTest(textBox);
    }

    [TestMethod]
    [DataRow("login", "username")]
    public void TextBoxFromHelperTest(string id, string text)
    {
        TextBoxHelper.TypeInTextBox(By.Id(id), text);
    }
    
    private void ClearTextBoxTest(IWebElement textBox)
    {
        textBox.Clear();
    }
}