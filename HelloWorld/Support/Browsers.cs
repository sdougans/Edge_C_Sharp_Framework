using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

public class Browsers
{
    public IWebDriver driver;

    public void Init(string browser)
    {
        switch (browser)
        {
            case "Chrome":
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                break;
            case "Firefox":
                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
                break;
            default:
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                break;
        }

    }

}