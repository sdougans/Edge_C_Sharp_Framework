using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Pages
{
    class WelcomePage
    {

        IWebDriver driver;

        public WelcomePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void clickLoginLink()
        {
            IWebElement loginLink = driver.FindElement(By.LinkText("Login"));
            loginLink.Click();
        }



    }

}
