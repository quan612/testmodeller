using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using Utilities;

namespace Pages
{
    public class Page_Objects : BasePage
    {
        public Page_Objects (IWebDriver driver)
            : base(driver)
        {

        }

        
	private By UsernameElem = By.XPath("(.//label[normalize-space()= 'Username'])[1]/../input");

	private By PasswordElem = By.XPath("//label[normalize-space()= 'Password']/../input");

	private By Sign_InElem = By.XPath("//INPUT[@value='Sign In']");

	private By Username_is_requiredElem = By.XPath("//SPAN[contains(text(),'Username is required.')]");

	private By Password_is_requiredElem = By.XPath("//SPAN[contains(text(),'Password is required.')]");


        
     
 	public void Assert_Password_is_required_OK()
 	{
 		IWebElement elem = getWebElement(Password_is_requiredElem);

 		if (elem == null) {
 			Assert.Fail("Unable to locate object: " + Password_is_requiredElem.ToString());
 		}
 	}

     
     public void AssertUrl()
     {
         String currentUrl = m_Driver.Url;

         if (!currentUrl.Equals("https://signals.transnomis.com/Account/SignIn?url=%2f%3f")) {
             Assert.Fail("Expecting URL - https://signals.transnomis.com/Account/SignIn?url=%2f%3f - Found " + currentUrl);
         }
     }

     
 	public void Assert_Username_is_required()
 	{
 		IWebElement elem = getWebElement(Username_is_requiredElem);

 		if (elem == null) {
 			Assert.Fail("Unable to locate object: " + Username_is_requiredElem.ToString());
 		}
 	}

     
 	public void Click_Sign_In()
 	{
 		IWebElement elem = getWebElement(Sign_InElem);

 		if (elem == null) {
     		TestModellerLogger.FailStepWithScreenshot(m_Driver, "Click_Sign_In", "Click_Sign_In failed. Unable to locate object: " + Sign_InElem.ToString());

 			Assert.Fail("Unable to locate object: " + Sign_InElem.ToString());
 		}

 		elem.Click();

		TestModellerLogger.PassStep(m_Driver, "Click_Sign_In");
 	}
     
 	public void Enter_Password(String Password)
 	{
 		IWebElement elem = getWebElement(PasswordElem);

 		if (elem == null) {
      		TestModellerLogger.FailStepWithScreenshot(m_Driver, "Enter_Password", "Enter_Password failed. Unable to locate object: " + PasswordElem.ToString());

 			Assert.Fail("Unable to locate object: " + PasswordElem.ToString());
 		}

 		elem.SendKeys(Password);

		TestModellerLogger.PassStep(m_Driver, "Enter_Password");
 	}
     
 	public void Enter_Username(String Username)
 	{
 		IWebElement elem = getWebElement(UsernameElem);

 		if (elem == null) {
      		TestModellerLogger.FailStepWithScreenshot(m_Driver, "Enter_Username", "Enter_Username failed. Unable to locate object: " + UsernameElem.ToString());

 			Assert.Fail("Unable to locate object: " + UsernameElem.ToString());
 		}

 		elem.SendKeys(Username);

		TestModellerLogger.PassStep(m_Driver, "Enter_Username");
 	}
     
 	public void GoToUrl()
 	{
 		m_Driver.Url = "https://signals.transnomis.com/Account/SignIn?url=%2f%3f";
 	}

     
 	public void Password_is_required()
 	{
 		IWebElement elem = getWebElement(Password_is_requiredElem);

 		if (elem == null) {
     		TestModellerLogger.FailStepWithScreenshot(m_Driver, "Click_Password_is_required", "Click_Password_is_required failed. Unable to locate object: " + Password_is_requiredElem.ToString());

 			Assert.Fail("Unable to locate object: " + Password_is_requiredElem.ToString());
 		}

 		Console.Log(123);

		TestModellerLogger.PassStep(m_Driver, "Click_Password_is_required");
 	}
    }
}