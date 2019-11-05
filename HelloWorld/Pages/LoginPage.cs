using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Pages
{
    class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void enterUsername(String username)
        {
            IWebElement usernameField = driver.FindElement(By.Id("username"));
            usernameField.SendKeys(username);
        }

        public void enterPassword(String password)
        {
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys(password);
        }

        public void clickSubmit()
        {
            IWebElement loginBtn = driver.FindElement(By.Id("login"));
            loginBtn.Click();
        }

        public void login(String username, String password)
        {
            enterUsername(username);
            enterPassword(password);
            clickSubmit();
        }

    }
}
