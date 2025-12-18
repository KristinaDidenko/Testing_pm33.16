using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class LoginPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    }

    // Метод для відкриття сторінки в браузері
    public void OpenLoginPage(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    // Метод для вибору опції "Login as Bank Manager"
    public void ClickLoginAsBankManager()
    {
        // Знайдіть елемент кнопки "Bank Manager Login" за допомогою селектора і натисніть на неї
        IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='Bank Manager Login']")));
        loginButton.Click();
    }

    public void CloseDriver()
    {
        driver.Quit();
    }

}
