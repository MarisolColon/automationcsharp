using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Exercise2automationCsharp
{
  [TestClass]
  public class UnitTest1
  {
    public string ClassNameToFindExpectedtitle = "_8est";
    public string ClassNameToFindExpectedText = "_8eso";

    [TestMethod]
    public void FaceboSingUp()
    {
      // Go to the "Facebook" homepage and fill up the sing up section
      IWebDriver driver = new ChromeDriver();
      driver.Navigate().GoToUrl("https://www.facebook.com/");
      BrowserCreation SetUp = new BrowserCreation(driver);
      SetUp.TypeInfoUser();

      // Validate text Sign Up
      var expectedtitle = "Sign Up";
      var actualtitle = driver.FindElement(By.ClassName(ClassNameToFindExpectedtitle)).Text.ToString();
      Assert.AreEqual(expectedtitle, actualtitle);

      //Select different default birthday 
      SetUp.ClickBirthdayButton();
      //Thread.Sleep(2000);

      //Select Female gender input
      SetUp.SelectGender();

      // Validate text Connect with friends and the world around you on Facebook.
      var expectedText = "Connect with friends and the world around you on Facebook.";
      var actualText = driver.FindElement(By.ClassName(ClassNameToFindExpectedText)).Text.ToString();
      Assert.AreEqual(expectedText, actualText);
    }
  }
}
