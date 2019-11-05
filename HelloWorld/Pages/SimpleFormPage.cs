using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Pages
{
    class SimpleFormPage
    {
        IWebDriver driver;

        public SimpleFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void waitforPageLoad()
        {
            driver.FindElement(By.Id("name"));
        }

        public void enterName(String name)
        {
            IWebElement nameField = driver.FindElement(By.Id("name"));
            nameField.SendKeys(name);
        }

        public void setGender(String gender)
        {
            IWebElement genderRadio;

            switch (gender)
            {
                case "Male":
                    genderRadio = driver.FindElement(By.Id("male"));
                    break;
                case "Female":
                    genderRadio = driver.FindElement(By.Id("female"));
                    break;
                case "Other":
                    genderRadio = driver.FindElement(By.Id("other"));
                    break;
                default:
                    genderRadio = driver.FindElement(By.Id("other"));
                    break;
            }

            genderRadio.Click();
        }

        public void setAge(String age)
        {
            IWebElement ageMenuItem = driver.FindElement(By.CssSelector("[value='" + age + "']"));
            ageMenuItem.Click();
        }

        public void enterPassword(String password)
        {
            IWebElement passwordField = driver.FindElement(By.Id("pass"));
            passwordField.SendKeys(password);
        }

        public void clickClear()
        {
            IWebElement clearBtn = driver.FindElement(By.Id("clear_btn"));
            clearBtn.Click();
        }

        public void clickSubmit()
        {
            IWebElement submitBtn = driver.FindElement(By.Id("submit_btn"));
            submitBtn.Click();
        }



        public String getNameResult()
        {
            IWebElement nameElement = driver.FindElement(By.CssSelector("[annoy1='name_text']"));
            return nameElement.Text;
        }

        public String getGenderResult()
        {
            IWebElement genderElement = driver.FindElement(By.CssSelector("[annoy2='gender_text']"));
            return genderElement.Text;
        }

        public String getAgeResult()
        {
            IWebElement ageElement = driver.FindElement(By.CssSelector("[annoy3='age_text']"));
            return ageElement.Text;
        }

        public String getPasswordResult()
        {
            IWebElement passwordElement = driver.FindElement(By.CssSelector("[annoy4='pass_text']"));
            return passwordElement.Text;
        }



    }
}
