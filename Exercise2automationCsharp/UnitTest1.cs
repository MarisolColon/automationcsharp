using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Exercise2automationCsharp
{
  [TestClass]
  public class UnitTest1
  {
    public string ClassNameToFind = "_8est";

    [TestMethod]
    public void FaceboSingUp()
    {
      // Go to the "Facebook" homepage and fill up the sing up section
      IWebDriver driver = new ChromeDriver();
      driver.Navigate().GoToUrl("https://www.facebook.com/");
      BrowserCreation SetUp = new BrowserCreation(driver);
      SetUp.TypeInfoUser();

      // Validate text 
      var expectedtitle = "Sign Up";
      var actualtitle = driver.FindElement(By.ClassName(ClassNameToFind)).Text.ToString();
      Assert.AreEqual(expectedtitle, actualtitle);

      //Select different default birthday 
      SetUp.ClickBirthdayButton();
      //Thread.Sleep(2000);

      //Select Female gender input
      SetUp.SelectGender();
    }
  }
}
