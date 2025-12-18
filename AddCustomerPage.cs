using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class AddCustomerPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public AddCustomerPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    }

    public void enterCustomer(string firstname, string lastname, string postcode)
    {
        //searchInput.Clear();
        Thread.Sleep(500);
        IWebElement firstNameInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//input[@placeholder='First Name']")));
        firstNameInput.SendKeys(firstname);
        IWebElement lastNameInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//input[@placeholder='Last Name']")));
        lastNameInput.SendKeys(lastname);
        IWebElement postCodeInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//input[@placeholder='Post Code']")));
        postCodeInput.SendKeys(postcode);
        IWebElement addCustomer = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[@type='submit']")));
        Thread.Sleep(1000);
        addCustomer.Click();
    }

    public string clickOk()
    {
        Thread.Sleep(2000);
        IAlert alert = driver.SwitchTo().Alert();
        string res = alert.Text;
        alert.Accept();
        return res;
    }
}
