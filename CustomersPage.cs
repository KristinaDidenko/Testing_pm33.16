using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class CustomersPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public CustomersPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    }

    public List<IWebElement> checkNewlyAddedPerson(out int n)
    {
        Thread.Sleep(3000);
        IList<IWebElement> customers = driver.FindElement(By.TagName("tbody")).FindElements(By.TagName("tr"));
        IWebElement person = customers[customers.Count - 1];
        n = customers.Count;
        return person.FindElements(By.TagName("td")).ToList<IWebElement>();
    }

    public int checkCountCustomers()
    {
        Thread.Sleep(2000);
        return driver.FindElement(By.TagName("tbody")).FindElements(By.TagName("tr")).Count;
    }
}
