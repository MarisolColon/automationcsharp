using System;
using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Exercise1AutomationCSharp
{
  class Program
  {
    IWebDriver driver;

    [SetUp]
    public void StartBrowser()
    {
      // Initialize the Chrome Driver
      driver = new ChromeDriver();
    }

    [Test]
    public void Test()
    {
      //Go to "Facebook" homepage
      driver.Url = "https://www.facebook.com/";

      //Verify that the following text is displayed
      var textvalidation = driver.FindElement(By.XPath("//div[text() = 'It’s quick and easy.']"));


      //Fill Firstname, Lastname and Mobile Number.
      var firstname = driver.FindElement(By.Name("firstname"));
      firstname.Click();
      firstname.SendKeys("Marisol");

      var lastname = driver.FindElement(By.Name("lastname"));
      lastname.Click();
      lastname.SendKeys("Colon");

      var movileNumber = driver.FindElement(By.Name("reg_email__"));
      firstname.Click();
      firstname.SendKeys("ADDVALUE");
      movileNumber.SendKeys("2533627171");

      //Assert to validate the text "It’s quick and easy."
      Assert.IsTrue(driver.PageSource.Contains("It’s quick and easy."));

      try
      {
        driver.FindElement(By.XPath("//div[text() = 'test-exercise.']"));
      }

      catch (NoSuchElementException ex)
      {
        Debug.WriteLine("ExceptionHandled");
        Debug.WriteLine(ex.Message);
      }

    }
    public static void Main()
    {
      Console.WriteLine();
    }
  }
}
