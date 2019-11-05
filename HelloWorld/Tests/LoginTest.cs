using HelloWorld.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace HelloWorld.Tests
{
    [Parallelizable]
    class LoginTest : TestBase
    {
        WelcomePage welcomePage;
        LoginPage loginPage;
        HomePage homePage;

        [SetUp]
        public void StartBrowser()
        {

        }


        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void LoginTest1(String browsername)
        {
            SetUp(browsername);
            welcomePage = new WelcomePage(driver);
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            welcomePage.clickLoginLink();

            loginPage.enterUsername("user1");
            loginPage.enterPassword("pass1");
            loginPage.clickSubmit();

            homePage.waitForPageLoad();
            Assert.IsTrue(homePage.getAllText().Contains("You are logged in!"));
            Console.WriteLine("Login test done");
        }

        [TearDown]
        public void CloseBrowser()
        {
            homePage.clickLink("Logout");
            driver.SwitchTo().Alert().Accept();
        }

    }
}