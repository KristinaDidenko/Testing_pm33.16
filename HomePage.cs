using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class HomePage
{
    private WebDriverWait wait;

    public HomePage(IWebDriver driver)
    {
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    }

    public void clickAddCustomer()
    {
        IWebElement addcustomer = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[contains(text(),'Add Customer')]")));
        addcustomer.Click();
    }

    public void ClickCustomers()
    {
        IWebElement customers = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[contains(text(),'Customers')]")));
        customers.Click();
    }
}
