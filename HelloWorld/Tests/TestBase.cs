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
            //Init("Chrome");
            //Init("Firefox");

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
            //String[] browsers = { "Chrome", "Firefox" };
            String[] browsers = { "Chrome" };

            foreach (String b in browsers)
            {
                yield return b;
            }
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            /*  Console.WriteLine("Generating report");
                Process.Start(@"C:\Users\sdougans\source\repos\HelloWorld\HelloWorld\Support\generate_allure_report.bat");
                Console.WriteLine("Report generated");
                Console.WriteLine("Opening report");
                Process.Start(@"C:\Users\sdougans\source\repos\HelloWorld\HelloWorld\Support\open_allure_report.bat");
                Console.WriteLine("Report opened");
            */

            Process proc = new Process();
            proc.StartInfo.FileName = @"C:\Users\sdougans\source\repos\HelloWorld\HelloWorld\Support\open_allure_report.bat";
            proc.StartInfo.WorkingDirectory = @"C:\Users\sdougans\source\repos\HelloWorld\HelloWorld\Support";
            proc.StartInfo.Verb = "runas";
            proc.Start();

            //Process.Start("cmd.exe", @"/c C:\Users\sdougans\source\repos\HelloWorld\HelloWorld\Support\generate_allure_report.bat");
        }

    }
}
