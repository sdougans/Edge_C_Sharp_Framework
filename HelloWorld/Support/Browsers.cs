using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

public class Browsers
{
    public IWebDriver driver;

    public void Init(string browser)
    {
        OperatingSystem os = Environment.OSVersion;
        String platform = os.Platform.ToString();

        switch (browser)
        {
            case "Chrome":
                if (platform == "Unix")
                    driver = new ChromeDriver("/Users/Stuart/Documents/SeleniumCourse/WebDrivers");
                else
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                }
                break;
            case "Firefox":
                if (platform == "Unix")
                    driver = new FirefoxDriver("/Users/Stuart/Documents/SeleniumCourse/WebDrivers");
                else
                {
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                }
                break;
            default:
                if (platform == "Unix")
                    driver = new ChromeDriver("/Users/Stuart/Documents/SeleniumCourse/WebDrivers");
                else
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                }
                break;
        }

    }

}