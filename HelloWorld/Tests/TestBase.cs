using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace HelloWorld.Tests
{

    [Parallelizable]
    class TestBase : Browsers
    {
        public void SetUp(String browsername, String url)
        {
            Init(browsername);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = url;
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }


        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "Chrome"};
            //String[] browsers = { "Chrome", "Firefox" };

            foreach (String b in browsers)
            {
                yield return b;
            }
        }

    }
}
