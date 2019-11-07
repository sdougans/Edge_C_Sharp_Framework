using HelloWorld.Pages;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HelloWorld.Tests
{
    [AllureNUnit]
    [Parallelizable]
    class Demo : TestBase
    {

        DemoPage demoPage;

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void SimpleSearchTest(String browsername)
        {
            SetUp(browsername, "https://duckduckgo.com/");
            demoPage = new DemoPage(driver);

            demoPage.enterSearchTest("Edgetesting");
            demoPage.clickSearchIcon();
            List<String> results = demoPage.lookForResult();

            Assert.IsTrue(results.Contains("www.edgetesting.co.uk"));
        }

    }
}