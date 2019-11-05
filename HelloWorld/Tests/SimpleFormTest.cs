using HelloWorld.Pages;
using NUnit.Framework;
using System;

namespace HelloWorld.Tests
{
    [Parallelizable]
    class SimpleFormTest : TestBase
    {
        HomePage homePage;
        LoginPage loginPage;
        WelcomePage welcomePage;
        SimpleFormPage simpleFormPage;

        [SetUp]
        public void StartBrowser()
        {

        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void SimpleFormTest1(String browsername)
        {
            SetUp(browsername);
            welcomePage = new WelcomePage(driver);
            welcomePage.clickLoginLink();

            loginPage = new LoginPage(driver);
            loginPage.login("user1", "pass1");

            homePage = new HomePage(driver);
            homePage.waitForPageLoad();

            simpleFormPage = new SimpleFormPage(driver);
            homePage.clickLink("Simple form");

            simpleFormPage.waitforPageLoad();

            simpleFormPage.enterName("Bruce Springsteen");
            simpleFormPage.setGender("Male");
            simpleFormPage.setAge("70");
            simpleFormPage.enterPassword("Born to Run");
            simpleFormPage.clickSubmit();

            String nameResult = simpleFormPage.getNameResult();
            String genderResult = simpleFormPage.getGenderResult();
            String ageResult = simpleFormPage.getAgeResult();
            String passwordResult = simpleFormPage.getPasswordResult();

            Assert.AreEqual(nameResult, "Bruce Springsteen");
            Assert.AreEqual(genderResult, "male");
            Assert.AreEqual(ageResult, "70");
            Assert.AreEqual(passwordResult, "Born to Run");
            Console.WriteLine("Simple test done");
        }

    }
}