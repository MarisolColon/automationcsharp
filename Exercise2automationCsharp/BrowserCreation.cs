using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2automationCsharp
{
  public class BrowserCreation
  {
    IWebDriver driver;
    //SingUP fill info
    By Firstname = By.Name("firstname");
    By Lastname = By.Name("lastname");
    By Email = By.Name("reg_email__");
    By ReEnterEmail = By.Name("reg_email_confirmation__");
    By Password = By.Name("reg_passwd__");

    //Select Birthday options input
    By month_button = By.CssSelector("#month > option:nth-child(4)");
    By date_button = By.CssSelector("#day > option:nth-child(16)");
    By year_button = By.CssSelector("#year > option:nth-child(39)");

    //Select Gender input
    By Female = By.CssSelector("span#u_0_y > span:nth-of-type(1)");
    By Male = By.CssSelector("span#u_0_y > span:nth-of-type(2)");

    public BrowserCreation(IWebDriver driver)
    {
      this.driver = driver;
    }

    public void TypeInfoUser()
    {
      driver.FindElement(Firstname).SendKeys("Marisol");
      driver.FindElement(Lastname).SendKeys("Colon");
      driver.FindElement(Email).SendKeys("marisol.colon@test.com");
      driver.FindElement(ReEnterEmail).SendKeys("marisol.colon@test.com");
      driver.FindElement(Password).SendKeys("password");
    }

    public void ClickBirthdayButton()
    {
      driver.FindElement(month_button).Click();
      driver.FindElement(date_button).Click();
      driver.FindElement(year_button).Click();

      //Wait for element visible
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      IWebElement dynamicElement = driver.FindElement(By.CssSelector("#month > option:nth-child(4)"));
    }

    public void SelectGender()
    {
      //driver.FindElement(Female).Click();
      //driver.FindElement(Male).Click();
    }

  }
}
