using HelloWorld.Pages;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;

namespace HelloWorld.Tests
{
    [AllureNUnit]
    [Parallelizable]
    class LoginTest : TestBase
    {
        WelcomePage welcomePage;
        LoginPage loginPage;
        HomePage homePage;

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

    }
}