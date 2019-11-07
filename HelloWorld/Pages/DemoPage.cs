using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HelloWorld.Pages
{
    class DemoPage
    {
        IWebDriver driver;

        public DemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void enterSearchTest(String searchText)
        {
            IWebElement search = driver.FindElement(By.CssSelector("#search_form_input_homepage"));
            search.SendKeys(searchText);
        }

        public void clickSearchIcon()
        {
            IWebElement searchIcon = driver.FindElement(By.CssSelector("#search_button_homepage"));
            searchIcon.Click();
        }

        public List<String> lookForResult()
        {
            ReadOnlyCollection<IWebElement> results = driver.FindElements(By.CssSelector(".result__url__domain"));

            List<String> list = new List<String>();
            foreach (IWebElement elem in results)
            {
                list.Add(elem.Text);
            }

            return list;

        }

    }
}
