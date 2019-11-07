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
        const String baseURL = "http://wsus-server01:81/EdgeTrainingTest/pages/welcomePage.html";

        public void SetUp(String browsername)
        {
            Init(browsername);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = baseURL;
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }


        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "Chrome", "Firefox" };

            foreach (String b in browsers)
            {
                yield return b;
            }
        }

    }
}
