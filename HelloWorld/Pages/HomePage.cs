using OpenQA.Selenium;
using System;

namespace HelloWorld.Pages
{
    class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickLink(String linkText)
        {
            IWebElement link = driver.FindElement(By.LinkText(linkText));
            link.Click();
        }

        public String getAllText()
        {
            IWebElement bodyElement = driver.FindElement(By.TagName("body"));
            return bodyElement.Text;
        }

        public void waitForPageLoad()
        {
            driver.FindElement(By.LinkText("Logout"));
        }

    }
}
